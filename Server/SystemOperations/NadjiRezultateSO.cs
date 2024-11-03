using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class NadjiRezultateSO : SystemOperationBase
    {
        RezultatIgraca rezultat;
        public List<RezultatIgraca> Result {  get; set; }
        public NadjiRezultateSO(RezultatIgraca rez)
        {
            rezultat = rez;
        }

        protected override void izvrisiOperaciju()
        {
            rezultat.JoinValues = "Rez.*, T.NazivTima";
            rezultat.JoinCondition = $" as Rez join Utakmica Ut on Ut.UtakmicaID = Rez.UtakmicaID join Igrac I on I.IgracID = Rez.IgracID join Tim T on I.IDTima = T.TimID where Rez.UtakmicaID = {rezultat.Utakmica.UtakmicaID} AND T.TimID = {rezultat.Igrac.Tim.TimID}";
            Result = getResult(broker.getAllWithCondition(rezultat));
        }

        private List<RezultatIgraca> getResult(List<IEntity> entities)
        {
            if(entities.Count == 0) return null;
            List<RezultatIgraca> tip = new List<RezultatIgraca>();
            foreach (IEntity ent in entities)
            {
                tip.Add((RezultatIgraca) ent);
            }
            return tip;
        }
    }
}
