using DBBroker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected Broker broker;

        public SystemOperationBase()
        {
            broker = new Broker();
        }

        public void ExecuteTemplate()
        {
            try
            {
                broker.otvoriKonekciju();
                broker.zapocniTransakciju();

                izvrisiOperaciju();

                broker.potvrdi();
            }
            catch (Exception ex)
            {
                broker.ponisti();
                Debug.WriteLine(">>>Ovde: " + ex.Message);
                throw ex;
            }
            finally
            {
                broker.zatvoriKonekciju();
            }
        }

        protected abstract void izvrisiOperaciju();
    }
}
