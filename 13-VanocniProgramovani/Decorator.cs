using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_vanocniProgramovani
{

    public abstract class Decorator

        : IWrapGift
    {
        protected IWrapGift _wrapping;

        protected Decorator(IWrapGift wrapping)
        {
            _wrapping = wrapping;
        }

        public virtual string Describe()
        {
            return _wrapping.Describe();
        }

        public virtual double Cost()
        {
            return _wrapping.Cost();
        }
    }
}
