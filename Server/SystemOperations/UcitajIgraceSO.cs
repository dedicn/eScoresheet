using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajIgraceSO : SystemOperationBase
    {
        private Utakmica utakmica;

        private Igrac igrac = new Igrac();
        public List<Igrac> Result { get; set; }

        public UcitajIgraceSO(Utakmica ut)
        {
            utakmica = ut;
        }

        protected override void izvrisiOperaciju()
        {
            igrac.JoinValues = $"Igrac.IgracID, Igrac.ImePrezime, Igrac.BrojDresa, Tim.TimID, Tim.NazivTima";
            igrac.JoinCondition = $"INNER JOIN Tim ON Igrac.IDTima = Tim.TimID INNER JOIN Utakmica ON (Utakmica.Domacin = Tim.TimID OR Utakmica.Gost = Tim.TimID)";
            string condition = $"where UtakmicaID = {utakmica.UtakmicaID}";
            Result = getResult(broker.getAllWithCondition(igrac, condition));
        }

        private List<Igrac> getResult(List<IEntity> entities)
        {
            List<Igrac> tipovi = new List<Igrac>();
            foreach (IEntity ent in entities)
            {
                tipovi.Add((Igrac)ent);
            }
            return tipovi;
        }
    }
}
