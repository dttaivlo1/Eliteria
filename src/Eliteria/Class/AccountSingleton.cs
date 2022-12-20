using Eliteria.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Eliteria.Class
{
   public sealed  class AccountSingleton
    {
        public static AccountSingleton Instance { get; } = new AccountSingleton();
        public List<Account> listAccount { get; }
        private AccountSingleton() {
   
        }
        public  void Init()
        {

        }
    }
}
