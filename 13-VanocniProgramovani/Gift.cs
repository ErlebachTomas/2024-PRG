using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_vanocniProgramovani
{
    public class Gift : IWrapGift
    {
        public string Description { get; }
        public string Recipient { get; }
        
        private double Price;

        public Gift(string description, string recipient, double price = 0.0)
        {
            Description = description;
            Recipient = recipient;
            Price = price;
        }

        public string Describe()
        {
            return $"{Recipient} dostane {Description}";
        }

        public double Cost()
        {
            return Price; 
        }

       
    }
}
