using System;

namespace UI.Pages.Login.Types
{
    public class ValidateLoginEventArgs : EventArgs
    {
        public ValidateLoginEventArgs(int intIdPerson, string strPassword)
        {
            IdPerson = intIdPerson;
            Password = strPassword;
        }

        public int IdPerson { get; }
        public string Password { get; }
    }
}