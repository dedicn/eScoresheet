using Common.Domain;
using DBBroker;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajTimoveSO: SystemOperationBase
    {
        private readonly Utakmica utakmicaId;

        public List<Tim> Result { get; set; }
        public UcitajTimoveSO(Utakmica id)
        {
            this.utakmicaId = id;
        }

        protected override void izvrisiOperaciju()
        {
            utakmicaId.JoinValues = $"Utakmica.*, Domacin.TimID as DomacinID, Domacin.NazivTima as DomacinNazivTima, Gost.TimID as GostID, Gost.NazivTima as GostNazivTima";
            utakmicaId.JoinCondition = $"INNER JOIN Tim AS Domacin ON Utakmica.Domacin = Domacin.TimID INNER JOIN Tim AS Gost ON Utakmica.Gost = Gost.TimID";
            string condition = $"where UtakmicaID = {utakmicaId.UtakmicaID}";
            Result = getResult(broker.getAllWithCondition(utakmicaId, condition));
        }

        private List<Tim> getResult(List<IEntity> entities)
        {
            if(entities.Count > 1)
            {
                throw new Exception("Greska prilikom dohvatanja timova");
            }
            List<Tim> tipovi = new List<Tim>();
            foreach (IEntity ent in entities)
            {
                Utakmica ut = (Utakmica)ent;
                Tim t = new Tim()
                {
                    TimID = ut.Domacin.TimID,
                    NazivTima = ut.Domacin.NazivTima,
                };
                tipovi.Add(t);

                Tim p = new Tim()
                {
                    TimID = ut.Gost.TimID,
                    NazivTima = ut.Gost.NazivTima,
                };
                tipovi.Add(p);
            }
            return tipovi;
        }
    }
}
