using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.work5
{
    public delegate bool EvenAndOddDelegate(int number);
    internal class work5
    {
        
        public List<int>? EvenNumbers { get; set; }
        public List<int>? OddNumbers { get; set; }  
        public bool ConditionEvenAndOdd(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public void MyNumbersForCondition(int FirstNumber, int LastNumber, EvenAndOddDelegate evenAndOddDelegate)
        {
            EvenNumbers = new List<int>();
            OddNumbers = new List<int>();
            if (evenAndOddDelegate == null) throw new ArgumentNullException(nameof(evenAndOddDelegate));
            for (int i = FirstNumber; i < LastNumber; i++)
            {
                if (!evenAndOddDelegate(i))
                    OddNumbers.Add(i);
                else
                    EvenNumbers.Add(i);
            }
        }
    }
}
