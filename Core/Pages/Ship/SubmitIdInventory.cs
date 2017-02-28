using System.Threading.Tasks;
using Core.Pages.Ship.Types;
using ServiceLayer;

namespace Core.Pages.Ship
{
    public static class SubmitIdInventory
    {
        public static async Task<SubmitIdInventoryResult> Execute(IShipService myShipService, string strIdInventoryInput)
        {
            if (strIdInventoryInput.Length == 0)
                return new SubmitIdInventoryResult();

            int intIdInventory;
            if (!int.TryParse(strIdInventoryInput, out intIdInventory))
                return new SubmitIdInventoryResult();
            //return Task.Factory.StartNew(() => new SubmitIdInventoryResult());

            var result = await myShipService.SubmitIdInventory(intIdInventory);
                        
            return new SubmitIdInventoryResult(result, intIdInventory);
        }
    }
}