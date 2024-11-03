using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class IzracunajRezultatSO : SystemOperationBase
    {
        RezultatCetvrtine rezultat;
        public RezultatCetvrtine Result {  get; set; }

        public IzracunajRezultatSO(RezultatCetvrtine rez)
        {
            rezultat = rez;
        }

        protected override void izvrisiOperaciju()
        {
            Result = new RezultatCetvrtine();
            Result.BrojCetvrtine = broker.AddAndReturnID(rezultat, "BrojCetvrtine");
        }
    }
}
