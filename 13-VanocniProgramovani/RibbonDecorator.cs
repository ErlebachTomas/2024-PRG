using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanocniProgramovani
{
    public class RibbonDecorator : Decorator
    {
        private string color;
        public RibbonDecorator(IGift gift, string color) : base(gift)
        {
            this.color = color;
        }
        public override string Describe()
        {
            return base.Describe() + $" s {color} stuhou";
        }

        public override double Cost()
        {
            return base.Cost() + 10;
        }


    }
}
