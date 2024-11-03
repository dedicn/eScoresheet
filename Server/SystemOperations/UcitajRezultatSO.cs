using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajRezultatSO : SystemOperationBase
    {
        RezultatIgraca rezultat;

        public RezultatIgraca Result {  get; set; }

        public UcitajRezultatSO(RezultatIgraca rez)
        {
            rezultat = rez;            
        }
        protected override void izvrisiOperaciju()
        {
            rezultat.JoinValues = "*";
            
            rezultat.JoinCondition = $"where UtakmicaID = {rezultat.Utakmica.UtakmicaID} AND IgracID = {rezultat.Igrac.IgracID}";
            Result = getResult(broker.getAllWithCondition(rezultat));
        }

        private RezultatIgraca getResult(List<IEntity> entities)
        {
            if (entities.Count != 1) throw new Exception("Greska prilikom dohvatanja igraca.");

            RezultatIgraca result = new RezultatIgraca();
            foreach (IEntity entity in entities)
            {
                result = (RezultatIgraca)entity;
            }

            return result;
        }
    }
}
