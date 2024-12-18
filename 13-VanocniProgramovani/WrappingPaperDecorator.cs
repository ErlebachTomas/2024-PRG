using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanocniProgramovani
{
    internal class WrappingPaperDecorator : Decorator
    {
        private string color;
        public WrappingPaperDecorator(IGift gift, string color) : base(gift)
        {
            this.color = color;

        }

        public override string Describe()
        {
            return base.Describe() + $" s {this.color} balicim papirem";
        }

        public override double Cost()
        {
            return base.Cost() + 15;
        }

    }
}
