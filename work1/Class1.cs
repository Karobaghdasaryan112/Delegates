using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.work1
{
    internal delegate int delegate1(int value1, int value2);

    public class Class1
    {
        public int Additional(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Multiplicate(int value1, int value2)
        {
            return value1 * value2;
        }
        public void Implementation1(int value1, int value2)
        {
            delegate1 @delegate = new delegate1(Additional);
            delegate1 @delegate1 = new delegate1(Multiplicate);
            @delegate(value1, value2);
            delegate1.Invoke(value1, value2);
        }
    }
}
