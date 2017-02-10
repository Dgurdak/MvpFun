using System;

namespace UI.UserControlPresenter
{
    public interface IShipPageControl
    {
        event EventHandler<IdSubmittedEventArgs> IdSubmitted;
        event EventHandler<WeightSubmittedEventArgs> WeightSubmitted;
        event EventHandler Cancel;
    }

    public class IdSubmittedEventArgs : EventArgs
    {
        public IdSubmittedEventArgs(int intIdInventory)
        {
            IdInventory = intIdInventory;
        }

        public int IdInventory { get; }
    }

    public class WeightSubmittedEventArgs : EventArgs
    {
        public WeightSubmittedEventArgs(decimal decWeight)
        {
            Weight = decWeight;
        }

        public decimal Weight { get; }
    }
}