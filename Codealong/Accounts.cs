using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong
{
    internal class Accounts
    {
        public string AccountName { get; set; }
        public int Money { get; set; }

        public Accounts(string accountName, int money)
        {
            AccountName = accountName;
            Money = money;
        }
    }
}
