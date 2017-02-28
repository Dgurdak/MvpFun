using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrinterInterface;
using ScaleInterface;
using ServiceLayer;
using UI.Constants;
using UI.Pages.Login;
using UI.Pages.ScaleSetup;
using UI.Pages.Ship;

namespace UI.MainForm
{
    public class MainFormPresenter
    {
        private IMainForm _view { get; set; }
        private MainFormViewModel _model { get; set; }
        private Dictionary<Constants.Pages, Control> _pages;

        private IShipService _shipService;
        private IScale _scale;
        private IPrinter _printer;

        public MainFormPresenter(IMainForm view, IShipService shipService, IScale myScale, IPrinter myPrinter, MainFormViewModel viewModel)
        {
            _shipService = shipService;
            _scale = myScale;
            _printer = myPrinter;
            _view = view;
            _model = viewModel;

            _view.BindToViewModel(viewModel);
            _pages = new Dictionary<Constants.Pages, Control>();
        }

        public MainFormPresenter(IMainForm view, MainFormViewModel model, Dictionary<Constants.Pages, Control> myPages)
        {
            _shipService = new ShipService();
            _scale = new UsbScale();
            _printer = new DatamaxPrinter();
            _view = view;
            _model = model;
            _pages = myPages;                        
        }


        private void LoginControlPresenter_AuthenticationPassed(object sender, string strUserName)
        {
            ShowControl(Constants.Pages.Ship);
        }

        private void LoginControlPresenter_AuthenticationFailed(object sender, EventArgs ea)
        {
            //do nothing, stuck forever
        }

        private void HideAllUserControls()
        {
            foreach (var page in _pages.Values) page.Hide();
        }

        public void ShowControl(Constants.Pages pageType)
        {                        
            //all pages should have been generated on start
            if (!_pages.ContainsKey(pageType))
                throw new Exception("Page not found");

            //hide all other pages and show just the desired one
            var myControl = _pages[pageType];        
            HideAllUserControls();
            myControl.Show();
            _view.AddControlToControlCollection(myControl);
        }

        public void AddControlToPagesDictionaryIfNotPresent(Constants.Pages myPageType, Control myControl)
        {
            if (_pages.ContainsKey(myPageType)) return;

            switch (myPageType)
            {
                case Constants.Pages.Login:                    
                    var loginControl = (ILoginControl)myControl;
                    var loginPresenter = new LoginControlPresenter(loginControl, new LoginViewModel(), _shipService);
                    loginPresenter.AuthenticationPassed += LoginControlPresenter_AuthenticationPassed;
                    loginPresenter.AuthenticationFailed += LoginControlPresenter_AuthenticationFailed;

                    _pages.Add(myPageType, myControl);
                    return;

                case Constants.Pages.Ship:
                    var shipControl = (IShipControl)myControl;
                    var shipPresenter = new ShipControlPesenter(shipControl, new ShipViewModel(), _shipService, _scale, _printer);
                    shipPresenter.PageChangeRequested += OnPageChangeRequested;

                    _pages.Add(myPageType, myControl);                
                    return;

                case Constants.Pages.ScaleSetup:
                    var scaleSetupControl = (IScaleSetupControl)myControl;
                    var scaleSetupPresenter = new ScaleSetupControlPresenter(scaleSetupControl, new ScaleSetupViewModel());
                    scaleSetupPresenter.PageChangeRequested += OnPageChangeRequested;
                    scaleSetupPresenter.ScaleSettingsChanged += ScaleSetupPresenterOnScaleSettingsChanged;

                    _pages.Add(myPageType, myControl);

                    return;

                default:
                    throw new ArgumentException("Page type does not exist");
            }
        }

        private void ScaleSetupPresenterOnScaleSettingsChanged(object sender, bool b)
        {
            if (!_pages.ContainsKey(Constants.Pages.ScaleSetup))
                throw new Exception("Scale setup page does not exist");

            ((IShipControl)_pages[Constants.Pages.Ship]).
        }

        private void OnPageChangeRequested(object sender, Constants.Pages desiredPage)
        {
            ShowControl(desiredPage);
        }
    }
}
