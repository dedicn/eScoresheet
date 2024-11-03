using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class IzbrisiUtakmicu : SystemOperationBase
    {
        private Utakmica igrac;

        public IzbrisiUtakmicu(Utakmica ut)
        {
            igrac = ut;
        }
        protected override void izvrisiOperaciju()
        {

            igrac.UpdateValues = $"UtakmicaID = {igrac.UtakmicaID}";
            broker.Delete(igrac);
        }
    }
}
