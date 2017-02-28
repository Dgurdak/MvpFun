namespace ServiceLayer.Types
{
    public class SubmitIdInventoryResult
    {
        public SubmitIdInventoryResult()
        {
            Success = false;
        }

        public SubmitIdInventoryResult(int intIdinventory)
        {
            Success = true;
            IdInventory = intIdinventory;
        }

        public int IdInventory { get; }
        public bool Success { get; }
    }
}