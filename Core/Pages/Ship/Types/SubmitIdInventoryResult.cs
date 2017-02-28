namespace Core.Pages.Ship.Types
{
    public class SubmitIdInventoryResult
    {
        public SubmitIdInventoryResult()
        {
            Success = false;
        }

        public SubmitIdInventoryResult(bool blnSuccess, int intIdinventory)
        {
            Success = blnSuccess;
            IdInventory = intIdinventory;
        }

        public int IdInventory { get; }
        public bool Success { get; }
    }
}