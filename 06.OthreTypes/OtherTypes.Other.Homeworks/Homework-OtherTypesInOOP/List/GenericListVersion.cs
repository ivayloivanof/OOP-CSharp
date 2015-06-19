using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
     [AttributeUsage(
        AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum
        | AttributeTargets.Method, AllowMultiple = true)]
    class GenericListVersion:System.Attribute
    {
          private int big;

          private int less;

        public GenericListVersion(int big, int less)
        {
            this.Big = big;
            this.Less = less;
        }

        public int Big
        {
            get
            {
                return this.big;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be a positive or zero!");
                }
                this.big = value;
            }
        }

        public int Less
        {
            get
            {
                return this.less;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException( "Value must be a positiv or zero!");
                }
                this.less = value;
            }
        }
    }
}
