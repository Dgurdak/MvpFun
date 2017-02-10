using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.UserControlPresenter
{
    public interface ILoginPageControl
    {
        event EventHandler SuccessfulLogin;
        event EventHandler<ValidateLoginEventArgs> ValidateLogin;

        void BindToViewModel();

    }

    public class ValidateLoginEventArgs : EventArgs
    {
        public int IdPerson { get; }
        public string Password { get; }

        public ValidateLoginEventArgs(int intIdPerson, string strPassword)
        {
            IdPerson = intIdPerson;
            Password = strPassword;
        }
    }
}
