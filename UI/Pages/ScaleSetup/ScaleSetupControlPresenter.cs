using System;
using UI.Constants;

namespace UI.Pages.ScaleSetup
{
    public class ScaleSetupControlPresenter : IGenericPagePresenter, ILoggedInPagePresenter
    {
        public ScaleSetupControlPresenter(IScaleSetupControl view, ScaleSetupViewModel model)
        {
            _view = view;
            _model = model;
            _view.SaveChangesButtonPressed += ScaleSetup_SaveChangesButtonPressed;
        }

        private IScaleSetupControl _view { get; }
        private ScaleSetupViewModel _model { get; }


        public void UserChanged()
        {
        }

        public event EventHandler<Constants.Pages> PageChangeRequested;

        private async void ScaleSetup_SaveChangesButtonPressed(object sender, EventArgs e)
        {
            ScaleSettingsChanged?.Invoke(this, _model.UseScale);
            PageChangeRequested?.Invoke(this, Constants.Pages.Ship);
        }

        public event EventHandler<bool> ScaleSettingsChanged;

        public void UpdateScaleEnabledCheckBox(bool blnScaleIsEnabled)
        {
            _model.UseScale = blnScaleIsEnabled;
        }
    }
}