using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajUtakmicuSO : SystemOperationBase
    {

        private Utakmica utakmica;
        public Utakmica Result { get; set; }

        public UcitajUtakmicuSO(Utakmica ut)
        {
            utakmica = ut;
        }
        protected override void izvrisiOperaciju()
        {
            utakmica.JoinValues = "Utakmica.*, Domacin.TimID as DomacinID, Domacin.NazivTima as DomacinNazivTima, Gost.TimID as GostID, Gost.NazivTima as GostNazivTima";
            utakmica.JoinCondition = $"INNER JOIN Tim AS Domacin ON Utakmica.Domacin = Domacin.TimID INNER JOIN Tim AS Gost ON Utakmica.Gost = Gost.TimID where UtakmicaID = {utakmica.UtakmicaID}";
            Result = getResult(broker.getAllWithCondition(utakmica));
        }

        private Utakmica getResult(List<IEntity> entities)
        {
            if (entities.Count != 1) throw new Exception("Greska prilikom dohvatanja utakmice.");

            Utakmica result = new Utakmica();
            foreach (IEntity entity in entities)
            {
                result = (Utakmica)entity;
            }

            return result;
        }
    }
}
