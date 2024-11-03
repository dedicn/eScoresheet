using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class NadjiUtakmiceSO : SystemOperationBase
    {
        private Utakmica utakmica;
        public List<Utakmica> Result { get; set; }

        public NadjiUtakmiceSO(Utakmica ut)
        {
            utakmica = ut;
        }
        protected override void izvrisiOperaciju()
        {
            utakmica.JoinValues = "Utakmica.*, Domacin.TimID as DomacinID, Domacin.NazivTima as DomacinNazivTima, Gost.TimID as GostID, Gost.NazivTima as GostNazivTima";           
            utakmica.JoinCondition = $"INNER JOIN Tim AS Domacin ON Utakmica.Domacin = Domacin.TimID INNER JOIN Tim AS Gost ON Utakmica.Gost = Gost.TimID";
            string conn = $"where UtakmicaID LIKE '%{utakmica.UtakmicaID}%' AND CAST(VremePocetka AS DATE) = CAST(GETDATE() AS DATE)";
            Result = getResult(broker.getAllWithCondition(utakmica, conn));
        }

        private List<Utakmica> getResult(List<IEntity> entities)
        {
            List<Utakmica> tipovi = new List<Utakmica>();
            foreach (IEntity ent in entities)
            {
                tipovi.Add((Utakmica)ent);
            }
            return tipovi;
        }
    }
}
