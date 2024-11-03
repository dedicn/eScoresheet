using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class NadjiIgrqaceSO : SystemOperationBase
    {
        Igrac igrac { get; set; }

        public List<Igrac> Result {  get; set; }

        public NadjiIgrqaceSO(Igrac ig)
        {
            igrac = ig;
        }
        protected override void izvrisiOperaciju()
        {
            igrac.JoinValues = $"Igrac.IgracID, Igrac.ImePrezime, Igrac.BrojDresa, Tim.TimID, Tim.NazivTima";
            igrac.JoinCondition = $"INNER JOIN Tim ON Igrac.IDTima = Tim.TimID INNER JOIN Utakmica ON (Utakmica.Domacin = Tim.TimID OR Utakmica.Gost = Tim.TimID)";
            string condition = $"where UtakmicaID = {igrac.UtakmicaID} and Igrac.ImePrezime LIKE '%{igrac.ImePrezime}%'";
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
