using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class KreirajRezultatSO : SystemOperationBase
    {
        RezultatIgraca rezultat;
        public RezultatIgraca Result { get; set; }
        public KreirajRezultatSO(RezultatIgraca rez)
        {
            rezultat = rez;
        }

        protected override void izvrisiOperaciju()
        {
            rezultat.JoinValues = "*";
            rezultat.JoinCondition = $"where UtakmicaID = {rezultat.Utakmica.UtakmicaID} AND IgracID = {rezultat.Igrac.IgracID}";
            RezultatIgraca pom = getResult(broker.getAllWithCondition(rezultat));

            if(pom.Utakmica == null || pom.Igrac == null)
            {
                broker.Add(rezultat);
                Result = rezultat;
            }
            else
            {
                Result = pom;
            }
        }

        private RezultatIgraca getResult(List<IEntity> entities)
        {
            if (entities.Count > 1) throw new Exception("Greska prilikom dohvatanja rezultata igraca");

            RezultatIgraca tip = new RezultatIgraca();
            foreach (IEntity ent in entities)
            {
                tip = (RezultatIgraca)ent;
            }
            return tip;
        }
    }
}
