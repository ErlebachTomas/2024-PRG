using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_vanocniProgramovani
{
    public class BoxDecorator : Decorator
    {
        public BoxDecorator(IWrapGift wrapping) : base(wrapping) { }

        public override string Describe()
        {
            return _wrapping.Describe() + " v krabici";
        }

        public override double Cost()
        {
            return _wrapping.Cost() + 16.0; // cena krabice
        }
    }
}
