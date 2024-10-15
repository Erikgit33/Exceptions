using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Divide<T>
    {
        T numerator;
        T denominator;

        public Divide(T numerator, T denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
    }
}
