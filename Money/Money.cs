using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
        public Money(string currency, double amount = 0)
        {
            Currency = currency;
            Amount = amount;
        }

        public double Amount { get; set; }
        public string Currency { get; private set; }

        public void ChangeCurrency(string newCurrency)
        {
            throw new NotImplementedException();
        }
    }
}
