using System;
using Core.Pages.Login;
using ServiceLayer;

namespace UI.Pages.Login
{
    public class LoginControlPresenter : IGenericPagePresenter
    {
        public LoginControlPresenter(ILoginControl view, LoginViewModel model, IShipService shipService)
        {
            View = view;
            Model = model;
            ShipService = shipService;
            View.BindToViewModel(model);
            View.SubmitButtonPressed += LoginControl_SubmitButtonPressed;
        }

        public ILoginControl View { get; set; }
        public LoginViewModel Model { get; set; }
        private IShipService ShipService { get; }

        public void UserChanged()
        {
            Model.Name = "";
            Model.Password = "";
            View.LoginErrorVisible = false;
        }

        public event EventHandler<string> AuthenticationPassed;
        public event EventHandler AuthenticationFailed;

        private async void LoginControl_SubmitButtonPressed(object sender, EventArgs e)
        {
            var blnLoginIsValid = await VerifyLoginCredentials.Execute(ShipService, Model.Name,
                Model.Password);

            if (!blnLoginIsValid)
            {
                Model.Name = "";
                Model.Password = "";
                View.LoginErrorVisible = true;
                AuthenticationFailed?.Invoke(this, new EventArgs());
                return;
            }

            Model.Name = "";
            Model.Password = "";
            View.LoginErrorVisible = false;
            AuthenticationPassed?.Invoke(this, Model.Name);
        }                
    }
}