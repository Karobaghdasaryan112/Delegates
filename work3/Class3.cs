using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.work3
{
    internal delegate double Square(double value);
    internal class Class3
    {
        public void CreateDelegate(double value)
        {
            Square @square = (value) => value * value;
            square(value);
        }
    }
}
