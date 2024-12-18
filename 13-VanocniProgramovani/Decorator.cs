using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanocniProgramovani
{
    public abstract class Decorator : IGift
    {
        protected IGift _gift;

        protected Decorator(IGift gift) { 
        
              _gift = gift;

        }
        public virtual double Cost()
        {
          return _gift.Cost();
        }

        public virtual string Describe()
        {
            return _gift.Describe();
        }
    }
}
