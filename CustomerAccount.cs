using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankManagent
{
    public class CustomerAccount
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
    }
}