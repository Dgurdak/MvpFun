using System;

namespace UI.Pages.ScaleSetup
{
    public interface IScaleSetupControl
    {
        event EventHandler SaveChangesButtonPressed;
        void BindToViewModel(ScaleSetupViewModel model);
    }
}