using System.Windows.Forms;
using UI.Constants;
using UI.MainForm;
using UI.Pages.Login;
using WinForms.Controls;

namespace WinForms.Utilities
{
    public class GetMainForm
    {
        public static Form Execute()
        {
            var mainForm = new MainForm();
            var mainFormViewModel = new MainFormViewModel();
            var mainFormPresenter = new MainFormPresenter(mainForm, mainFormViewModel);

            var loginPresenter = new LoginControlPresenter(mainForm, );

            //note that in the real thing instead of adding them like this and calling showControl here,
            //i might actually pass in a list of kvp(pageType, new control) and have the construct gen up all of the pages
            //Then the constructor would go to the first page (login)
            mainFormPresenter.AddControlToPagesDictionaryIfNotPresent(Pages.Login, new LoginControl());
            mainFormPresenter.AddControlToPagesDictionaryIfNotPresent(Pages.Ship, new ShipControl());
            mainFormPresenter.AddControlToPagesDictionaryIfNotPresent(Pages.ScaleSetup, new ScaleSetupControl());
            mainFormPresenter.ShowControl(Pages.Login);

            return mainForm;
        }
    }
}