using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_vanocniProgramovani
{
    public class WrappingPaperDecorator : Decorator
    {
        private string _colorOrPattern;

        public WrappingPaperDecorator(IWrapGift wrapping, string colorOrPattern) : base(wrapping)
        {
            _colorOrPattern = colorOrPattern;
        }

        public override string Describe()
        {
            return _wrapping.Describe() + $" s {_colorOrPattern} balicím papírem";
        }

        public override double Cost()
        {
            return _wrapping.Cost() + 5.0; 
        }
    }
}
