using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UnesiIgracaSO : SystemOperationBase
    {
        private Igrac igrac;

        public UnesiIgracaSO(Igrac i)
        {
            this.igrac = i;
        }
        protected override void izvrisiOperaciju()
        {
            broker.Add(igrac);
        }
    }
}
