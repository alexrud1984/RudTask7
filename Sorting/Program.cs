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

            Something[] userArray = new Something[5];
            userArray[0] = new Something { Name = "Car" };
            userArray[1] = new Something { Name = "Moto" };
            userArray[2] = new Something { Name = "Bike" };
            userArray[3] = new Something { Name = "Tram" };
            userArray[4] = new Something { Name = "Bas" };

            BubbleSorter<Something> bubble = new BubbleSorter<Something>(userArray.Clone() as Something[]);
            bubble.Print();
            bubble.Sort();
            bubble.Print();

            InsertionSorter<Something> insrt = new InsertionSorter<Something>(userArray.Clone() as Something[]);
            insrt.Print();
            insrt.Sort();
            insrt.Print();
            
            Console.ReadKey();
        }
    }
}
