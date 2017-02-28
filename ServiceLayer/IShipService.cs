using System.Threading.Tasks;
using ServiceLayer.Types;

namespace ServiceLayer
{
    public interface IShipService
    {
        Task<bool> LoginIsValid(string strName, string strPassword);
        Task<bool> SubmitIdInventory(int idInventory);
        Task<SubmitWeightResultCodes> SubmitWeight(int idInventory, decimal decWeight);
    }
}