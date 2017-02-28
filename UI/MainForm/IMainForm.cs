using System;
using UI.Pages.Login;
using UI.Pages.ScaleSetup;
using UI.Pages.Ship;

namespace UI.MainForm
{
    public interface IMainForm
    {
        event EventHandler LogOut;
        event EventHandler Login;

        Constants.Pages ActivePage { get; set; }
        ILoginControl LoginControl { get; }
        IShipControl ShipControl { get; }
        IScaleSetupControl ScaleControl { get; }        

        void BindToViewModel(MainFormViewModel viewModel);
        void GoToPage(Constants.Pages page);
    }
}