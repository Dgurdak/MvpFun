using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServiceLayer.Types;

namespace ServiceLayer
{
    public class ShipService : IShipService
    {
        public Task<bool> LoginIsValid(string strName, string strPassword)
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return strName == "David" && strPassword == "Test";
            });
        }

        public Task<bool> SubmitIdInventory(int idInventory)
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(700);
                return true;
            });
        }
    

        public Task<SubmitWeightResultCodes> SubmitWeight(int idInventory, decimal decWeight)
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                return SubmitWeightResultCodes.Success;
            });
        }
    }
}
