using System.Collections.Generic;

namespace ScaleInterface
{
    public interface IScale
    {
        KeyValuePair<bool, decimal> ReadWeightFromScale();
    }
}