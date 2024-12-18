using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanocniProgramovani
{
    internal class BoxDecorator : Decorator
    {

        public BoxDecorator(IGift gift) : base(gift)
        {
        }

        public override string Describe()
        {
            return base.Describe() + " v krabici";
        }

        public override double Cost()
        {
            return base.Cost() + 20; // cena za krabici
        }
    }
}
