using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Pages.Ship.Utilities;
using ScaleInterface;
using ServiceLayer;
using ServiceLayer.Types;

namespace Core.Pages.Ship
{
    public static class SubmitWeight
    {
        public static Task<SubmitWeightResultCodes> Execute(IShipService myShipService, IScale myScale,
            int intIdIinventory,
            string strManualEntryWeight, bool blnUseScale)
        {
            decimal decWeight;

            KeyValuePair<bool, decimal> weightResult;
            if (blnUseScale)
            {
                weightResult = myScale.ReadWeightFromScale();
                if (!weightResult.Key)
                    return Task.Factory.StartNew(() => SubmitWeightResultCodes.WeightIsTooLow);
            }
            else
            {
                weightResult = GetManualEntryWeight.Execute(strManualEntryWeight);
                if (!weightResult.Key)
                    return Task.Factory.StartNew(() => SubmitWeightResultCodes.FailedToReadScale);
            }

            decWeight = weightResult.Value;

            if (!BusinessRules.IsWeightAcceptable.Execute(decWeight))
                return Task.Factory.StartNew(() => SubmitWeightResultCodes.FailedToReadScale);

            return myShipService.SubmitWeight(intIdIinventory, decWeight);
        }
    }
}