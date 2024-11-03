using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class IzbrisiIgrace : SystemOperationBase
    {
        private Tim igrac;

        public IzbrisiIgrace(Tim ut)
        {
            igrac = ut;
        }
        protected override void izvrisiOperaciju()
        {
            Igrac ig = new Igrac();
            ig.Tim = new Tim();
            ig.Tim.TimID = igrac.TimID;
            ig.UpdateValues = $"IdTima = {ig.Tim.TimID}";
            broker.Delete(ig);
        }
    }
}
