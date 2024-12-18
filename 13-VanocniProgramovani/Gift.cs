using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanocniProgramovani
{
    internal class Gift : IGift
    {
        public string Desription { get; set; }

        public string Recipient { get; set; }

        private double Price;
        
        public Gift(string desription, string recipient, double price = 0.0)
        {
            Desription = desription;
            Recipient = recipient;
            Price = price;
        }
        public double Cost()
        {
            return Price;
        }
        public string Describe()
        {
            return $"{Recipient} dostane {Desription}";
        }
    }
}
