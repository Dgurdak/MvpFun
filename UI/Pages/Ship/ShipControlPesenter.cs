using System;
using Core.Pages.Ship;
using PrinterInterface;
using ScaleInterface;
using ServiceLayer;
using ServiceLayer.Types;
using UI.Constants;
using UI.Pages.Ship.Constants;

namespace UI.Pages.Ship
{
    public class ShipControlPesenter : IGenericPagePresenter, ILoggedInPagePresenter
    {
        private int _intCurrentIdInventory;
        private int _intShippedCount = 0;

        public ShipControlPesenter(IShipControl view, ShipViewModel model, IShipService shipService, IScale myScale, IPrinter myPrinter)
        {
            _view = view;
            _model = model;
            _shipService = shipService;
            _scale = myScale;
            _printer = myPrinter;
            _view.BindToViewModel(model);
            _view.SubmitIdInventoryButtonPressed += ShipControl_SubmitIdInventoryButtonPressed;
            _view.SubmitWeightButtonPressed += ShipControl_SubmitWeightButtonPressed;
            _view.CancelButtonPressed += ShipControl_CancelButtonPressed;
            _view.GoToCustomizeScalePageButtonPressed += ShipControl_GoToCustomizeScalePageButtonPressed;

            UpdateState(ShipStates.WaitingForIdInventory);
        }

        public IShipControl _view { get; set; }
        public ShipViewModel _model { get; set; }
        private IShipService _shipService { get; set; }
        private IScale _scale { get; set; }
        private bool _blnScaleIsEnabled { get; set; }
        private IPrinter _printer { get; set; }

        private ShipStates ShipState { get; set; }

        public void UserChanged()
        {
            UpdateState(ShipStates.WaitingForIdInventory);
            ShippedCount = 0;
        }

        public event EventHandler<UI.Constants.Pages> PageChangeRequested;

        public void ScaleEnabledChanged(bool blnScaleIsEnabled)
        {
            _blnScaleIsEnabled = blnScaleIsEnabled;
            if (blnScaleIsEnabled)
                _model.ScaleStatus = "Online";
            else
                _model.ScaleStatus = "Offline";
        }

        private async void ShipControl_SubmitIdInventoryButtonPressed(object sender, EventArgs e)
        {                   
            var result = await SubmitIdInventory.Execute(_shipService, _model.IdInventory);
            _intCurrentIdInventory = result.IdInventory;

            if (!result.Success)
            {
                UpdateState(ShipStates.WaitingForIdInventory);
                UpdateResult("Ship attempt failed");
                return;
            }            

            UpdateState(ShipStates.WaitingForWeight);
        }

        private async void ShipControl_SubmitWeightButtonPressed(object sender, EventArgs e)
        {
            var result = await SubmitWeight.Execute(_shipService, _scale, _intCurrentIdInventory, _model.Weight,
                _blnScaleIsEnabled);           

            switch (result)
            {
                case SubmitWeightResultCodes.FailedToReadScale:
                    UpdateState(ShipStates.WaitingForWeight);
                    UpdateResult("Scale failure");
                    return;

                case SubmitWeightResultCodes.WeightIsTooLow:
                    UpdateState(ShipStates.WaitingForWeight);
                    UpdateResult("Bad Weight: too small");
                    return;
            }

            _printer.Print("result is: " + result);

            UpdateState(ShipStates.WaitingForIdInventory);
            UpdateResult("Shipped!");
            ShippedCount++;
        }

        private async void ShipControl_CancelButtonPressed(object sender, EventArgs e)
        {
            UpdateState(ShipStates.WaitingForIdInventory);
        }

        private async void ShipControl_GoToCustomizeScalePageButtonPressed(object sender, EventArgs e)
        {
            PageChangeRequested?.Invoke(this, UI.Constants.Pages.ScaleSetup);
        }

        private void UpdateResult(string strResult)
        {
            _model.Result = strResult;
        }

        private void UpdateState(ShipStates desiredShipState)
        {
            ShipState = desiredShipState;
            switch (desiredShipState)
            {
                case ShipStates.WaitingForIdInventory:
                    SetStateWaitingForIdInventory();
                    break;

                case ShipStates.WaitingForWeight:
                    SetStateWaitingForWeight();
                    break;
            }
        }

        private void SetStateWaitingForIdInventory()
        {
            _model.IdInventory = "";
            _model.IdInventoryInputEnabled = true;
            _model.SubmitIdInventoryButtonEnabled = true;

            _model.Weight = "";
            _model.WeightInputEnabled = false;
            _model.SubmitWeightButtonEnabled = false;

            _model.CancelButtonEnabled = false;
        }

        private void SetStateWaitingForWeight()
        {
            _model.IdInventoryInputEnabled = false;
            _model.SubmitIdInventoryButtonEnabled = false;

            _model.Weight = "";
            _model.WeightInputEnabled = true;
            _model.SubmitWeightButtonEnabled = true;

            _model.CancelButtonEnabled = true;
            _model.Result = "";
        }

        private int ShippedCount
        {
            get { return _intShippedCount; }
            set
            {
                _intShippedCount = value;
                _model.ShippedCount = _intShippedCount.ToString();
            }
        }
    }
}