using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajTimSO : SystemOperationBase
    {
        private Tim tim;

        public Tim Result { get; set; }

        public UcitajTimSO(Tim t)
        {
            tim = t;
        }
        protected override void izvrisiOperaciju()
        {
            tim.JoinValues = "*";
            tim.JoinCondition = $"where TimId = {tim.TimID}";
            Result = getResult(broker.getAllWithCondition(tim));
        }

        private Tim getResult(List<IEntity> entities)
        {
            if(entities.Count != 1) throw new Exception("Greska prilikom dohvatanja tima.");

            Tim result = new Tim();
            foreach(IEntity entity in entities)
            {
                result = (Tim)entity;
            }

            return result;
        }
    }
}
