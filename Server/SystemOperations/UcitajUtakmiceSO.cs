using Common.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajUtakmiceSO : SystemOperationBase
    {
        private Utakmica utakmica;
        public List<Utakmica> Result{ get; set; }

        public UcitajUtakmiceSO()
        {
            
        }
        protected override void izvrisiOperaciju()
        {
            utakmica = new Utakmica();
            utakmica.JoinValues = "Utakmica.*, Domacin.TimID as DomacinID, Domacin.NazivTima as DomacinNazivTima, Gost.TimID as GostID, Gost.NazivTima as GostNazivTima";
            utakmica.JoinCondition = $"INNER JOIN Tim AS Domacin ON Utakmica.Domacin = Domacin.TimID INNER JOIN Tim AS Gost ON Utakmica.Gost = Gost.TimID where CAST(VremePocetka AS DATE) = CAST(GETDATE() AS DATE)";
            Result = getResult(broker.getAllWithCondition(utakmica));
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
