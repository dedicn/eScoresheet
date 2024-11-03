using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajTipoveUtakmicaSO : SystemOperationBase
    {
        private readonly TipUtakmice kategorije = new TipUtakmice();
        public List<TipUtakmice> Result { get; set; }

        protected override void izvrisiOperaciju()
        {
            Result = GetResult(broker.getAll(kategorije));
        }

        public List<TipUtakmice> GetResult(List<IEntity> lista)
        {
            List<TipUtakmice> tipovi = new List<TipUtakmice>();
            foreach (IEntity ent in lista)
            {
                tipovi.Add((TipUtakmice)ent);
            }
            return tipovi;
        }
    }
}
