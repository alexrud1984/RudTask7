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
            Something[] userArray = new Something [5];
            Console.WriteLine("Give the names for 5 something");
            for (int i = 0; i < 5; i++)
            {
                userArray[i] = new Something();
                userArray[i].Name=Console.ReadLine();
            }

            BubbleSorter bubble = new BubbleSorter(userArray.Clone() as Something[]);
            bubble.Print();
            bubble.Sort();
            bubble.Print();

            InsertionSorter insrt = new InsertionSorter(userArray.Clone() as Something[]);
            insrt.Print();
            insrt.Sort();
            insrt.Print();

            Console.ReadKey();
        }
    }
}
