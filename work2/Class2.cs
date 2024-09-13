using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.work2
{
    internal delegate void AnanymousDelegate(string str);
    internal class Class2
    {
        public void AnanymousMethod(string str)
        {
            AnanymousDelegate @delegate = delegate (string str)
            {
                Console.WriteLine(str);
            };
            @delegate(str);
        }
        public void AnanymousMethodWithLambda(string str)
        {
            AnanymousDelegate @delegate = (str) => Console.WriteLine(str);
            @delegate(str);
        }
    }
}
