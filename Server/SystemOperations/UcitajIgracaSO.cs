using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajIgracaSO : SystemOperationBase
    {
        private Igrac igrac;
        public Igrac Result { get; set; }

        public UcitajIgracaSO(Igrac ut)
        {
            igrac = ut;
        }
        protected override void izvrisiOperaciju()
        {
            igrac.JoinValues = "Igrac.*, Tim.NazivTima";
            igrac.JoinCondition = $"join Tim on IDTima = Tim.TimID where IgracID = {igrac.IgracID}";
            Result = getResult(broker.getAllWithCondition(igrac));
        }

        private Igrac getResult(List<IEntity> entities)
        {
            if (entities.Count != 1) throw new Exception("Greska prilikom dohvatanja igraca.");

            Igrac result = new Igrac();
            foreach (IEntity entity in entities)
            {
                result = (Igrac)entity;
            }

            return result;
        }
    }
}
