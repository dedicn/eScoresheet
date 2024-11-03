using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Server.SystemOperations
{
    internal class IzmeniIgracaSO : SystemOperationBase
    {
        private Igrac igrac;

        public IzmeniIgracaSO(Igrac ut)
        {
            igrac = ut;
        }
        protected override void izvrisiOperaciju()
        {
            igrac.UpdateValues = "ImePrezime = '" + igrac.ImePrezime + "', BrojDresa = '" + igrac.BrojDresa + "' " + ", IDTima = " + igrac.Tim.TimID;
            igrac.UpdateCondition = $"IgracID = {igrac.IgracID}";
            broker.Update(igrac);
        }
    }
}
