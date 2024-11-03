using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class IzbrisiTim : SystemOperationBase
    {
        private Tim igrac;

        public IzbrisiTim(Tim ut)
        {
            igrac = ut;
        }
        protected override void izvrisiOperaciju()
        {

            igrac.UpdateValues = $"TimID = {igrac.TimID}";
            broker.Delete(igrac);
        }
    }
}
