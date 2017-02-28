using System.Collections.Generic;

namespace ScaleInterface
{
    public class UsbScale : IScale
    {
        public KeyValuePair<bool, decimal> ReadWeightFromScale()
        {
            return new KeyValuePair<bool, decimal>(true, 9.9M);
        }
    }
}