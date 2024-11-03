using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class IzmeniUtakmicuSO : SystemOperationBase
    {
        private Utakmica utakmica;

        public IzmeniUtakmicuSO(Utakmica ut)
        {
            utakmica = ut;            
        }
        protected override void izvrisiOperaciju()
        {
            string vre = utakmica.VremeZavrsetka == null ? "" : utakmica.VremeZavrsetka.ToString();
            utakmica.UpdateValues = "VremePocetka = '" + utakmica.VremePocetka + "', VremeZavrsetka = '" + utakmica.VremeZavrsetka + "', Mesto = '" + utakmica.Mesto + "', IDTipa = " + utakmica.Tip.TipID;
            utakmica.UpdateCondition = $"UtakmicaID = {utakmica.UtakmicaID}";
            broker.Update(utakmica);

            if(utakmica.cetvrtine.Count > 0)
            {
                foreach(RezultatCetvrtine rez in utakmica.cetvrtine)
                {
                    broker.Add(rez);
                }
            }
        }
    }
}
