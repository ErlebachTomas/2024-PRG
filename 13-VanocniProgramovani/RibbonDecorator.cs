using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_vanocniProgramovani
{
    public class RibbonDecorator : Decorator
    {
        private string _color;

        public RibbonDecorator(IWrapGift wrapping, string color) : base(wrapping)
        {
            _color = color;
        }

        public override string Describe()
        {
            return _wrapping.Describe() + $" a {_color} stuhou";
        }

        public override double Cost()
        {
            return _wrapping.Cost() + 3.0; 
        }
    }
}
