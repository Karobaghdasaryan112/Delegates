using System;
using Delegates.Work7;
using Delegates.work8.cs;
namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                2,9,1,5,3,6,4,5,8,1
            };
            working7 work7 = new working7(list);
            work7.ImplementSorting();
            List<int> DescendingSortNumbers = work7.DescendingSort();
            foreach (var item in DescendingSortNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}