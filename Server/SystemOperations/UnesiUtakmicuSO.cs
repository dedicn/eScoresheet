using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UnesiUtakmicuSO: SystemOperationBase
    {
        private readonly Utakmica utakmicaId;


        public UnesiUtakmicuSO(Utakmica id)
        {
            this.utakmicaId = id;
        }

        protected override void izvrisiOperaciju()
        {
            broker.Add(utakmicaId);
        }
    }
}
