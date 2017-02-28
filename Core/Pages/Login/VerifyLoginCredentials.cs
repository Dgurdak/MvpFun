using System.Threading.Tasks;
using ServiceLayer;

namespace Core.Pages.Login
{
    public static class VerifyLoginCredentials
    {
        public static Task<bool> Execute(IShipService myShipService, string strUserName, string strPassword)
        {
            return myShipService.LoginIsValid(strUserName, strPassword);
        }
    }
}