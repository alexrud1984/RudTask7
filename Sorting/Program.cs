using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] userArray = new int [] {42, 54, 555, 32, 1, -100, 0, 12 };

            BubbleSorter <int> bubble = new BubbleSorter<int>(userArray.Clone() as int[]);
            bubble.Print();
            bubble.Sort();
            bubble.Print();

            InsertionSorter <int> insrt = new InsertionSorter <int>(userArray.Clone() as int[]);
            insrt.Print();
            insrt.Sort();
            insrt.Print();

            Console.ReadKey();
        }
    }
}
