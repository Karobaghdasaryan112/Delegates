using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Work7
{

    public delegate bool SortingConditionDelegate(int number1,int number2);
    internal class working7
    {
        public List<int> Numbers {  get; set; }
        private List<int> AscendingSortNumbers { get; set; }
        private List<int> DescendingSortNumbers { get; set; }    

        public working7(List<int> Numbers)
        {
            this.Numbers = Numbers;
        }
        public List<int> AscendingSort()
        {
            return AscendingSortNumbers;
        }
        public List<int> DescendingSort()
        {
            return DescendingSortNumbers;   
        }
        public void ImplementSorting()
        {
            AscendingSortNumbers = new List<int>();
            DescendingSortNumbers = new List<int>();
            SortingConditionDelegate sortingCondition = new SortingConditionDelegate(ConditionSorting);
            for (int i = 0; i < Numbers.Count; i++)
            {
                for(int j = 0; j < Numbers.Count; j++)
                {
                    sortingCondition(i, j);
                }
            }
            AscendingSortNumbers = Numbers;
            DescendingSortNumbers = Numbers.AsEnumerable().Reverse().ToList();
        }
        private bool ConditionSorting(int i,int j)
        {
            if (Numbers[i] <=Numbers[j])
            {
                int Swap = Numbers[i];
                Numbers[i] = Numbers[j];
                Numbers[j] = Swap;
            }
            return false;
        }
    }
}
