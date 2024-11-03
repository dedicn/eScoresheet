using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class IzmeniTimSO : SystemOperationBase
    {
        private Tim tim;

        public IzmeniTimSO(Tim ut)
        {
            tim = ut;
        }
        protected override void izvrisiOperaciju()
        {
            tim.UpdateValues = "NazivTima = '" + tim.NazivTima + "'";
            tim.UpdateCondition = $"TimID = {tim.TimID}";
            broker.Update(tim);
        }
    }
}
