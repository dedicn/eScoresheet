using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class ObrisiRezultatSO : SystemOperationBase
    {
        RezultatIgraca rezultat;

        public ObrisiRezultatSO(RezultatIgraca rez)
        {
            rezultat = rez;
        }
        protected override void izvrisiOperaciju()
        {
            rezultat.UpdateValues = $"BrojPoena = {rezultat.BrojPoena}, BrojLicnihGresaka = {rezultat.BrojLicnihGresaka}";
            rezultat.UpdateCondition = $"UtakmicaID = {rezultat.Utakmica.UtakmicaID} AND IgracID = {rezultat.Igrac.IgracID}";
            broker.Update(rezultat);
        }
    }
}
