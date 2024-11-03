using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class LoginSO : SystemOperationBase
    {
        private readonly Zapisnicar zapisnicar;
        public Zapisnicar Result { get; set; }

        public LoginSO(Zapisnicar zapisnicar)
        {
            this.zapisnicar = zapisnicar;
        }

        protected override void izvrisiOperaciju()
        {
            Result = broker.Login(zapisnicar);
        }
        
    }
}
