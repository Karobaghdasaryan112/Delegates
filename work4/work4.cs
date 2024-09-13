using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.work4
{
    public delegate void MulticastDelegate();
    internal class work4
    {
        public void Method1()
        {
            Console.Write("hello ");
        }
        public void Method2()
        {
            Console.WriteLine("world");
        }
        public void MultiCasting()
        {
            MulticastDelegate? @delegate = null;
            MulticastDelegate multicast1 = new MulticastDelegate(Method1);
            MulticastDelegate multicast2 = new MulticastDelegate(Method2);
            @delegate = (MulticastDelegate)Delegate.Combine(@delegate, multicast1);
            @delegate = (MulticastDelegate)Delegate.Combine(@delegate, multicast2);
            @delegate.Invoke();
        }
    }
}
