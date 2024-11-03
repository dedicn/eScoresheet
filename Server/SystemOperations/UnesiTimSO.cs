using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UnesiTimSO : SystemOperationBase
    {
        private readonly Tim tim ;
        public Tim Result{ get; set; }

        public UnesiTimSO(Tim tim)
        {
            this.tim = tim;
        }
        protected override void izvrisiOperaciju()
        {
            tim.TimID = broker.AddAndReturnID(tim, "TimID");
            Result = tim;
        }
    }
}
