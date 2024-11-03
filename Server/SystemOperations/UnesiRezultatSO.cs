using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UnesiRezultatSO : SystemOperationBase
    {
        Utakmica rezultat;

        public UnesiRezultatSO(Utakmica rez)
        {
            rezultat = rez;
        }

        protected override void izvrisiOperaciju()
        {
            if(rezultat.igraci.Count != 0)
            {
                foreach(RezultatIgraca r in  rezultat.igraci)
                {
                    r.UpdateValues = $"BrojLicnihGresaka = {r.BrojLicnihGresaka}, BrojPoena = {r.BrojPoena}";
                    r.UpdateCondition = $"UtakmicaID = {r.Utakmica.UtakmicaID} AND IgracID = {r.Igrac.IgracID}";
                    broker.Update(r);
                }
            }
            
        }
    }
}
