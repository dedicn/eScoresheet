using Common.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class NadjiTimoveSO : SystemOperationBase
    {
        private Tim tim;
        public List<Tim> Result { get; set; }
        public NadjiTimoveSO(Tim t)
        {
            tim = t;
        }
        protected override void izvrisiOperaciju()
        {
            tim.JoinValues = "TimID, NazivTima";
            tim.JoinCondition = $"JOIN Utakmica ON Tim.TimID = Utakmica.Domacin OR Tim.TimID = Utakmica.Gost";
            string conn = $"WHERE LOWER(Tim.NazivTima) LIKE '%{tim.NazivTima}%' AND Utakmica.UtakmicaID = {tim.UtakmicaID}";
            Result = getResult(broker.getAllWithCondition(tim, conn));
        }

        private List<Tim> getResult(List<IEntity> entities)
        {
            List<Tim> tipovi = new List<Tim>();
            foreach (IEntity ent in entities)
            {
                tipovi.Add((Tim)ent);
            }
            return tipovi;
        }
    }
}
