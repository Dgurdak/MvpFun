using System;
using UI.Pages.Login.Types;

namespace UI.Pages.Login
{
    public interface ILoginControl
    {        
        event EventHandler SubmitButtonPressed;
        void BindToViewModel(LoginViewModel model);
        bool LoginErrorVisible { get; set; }
    }
}