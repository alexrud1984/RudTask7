using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class Sorter : ISorter<Something []>
    {
        protected Something [] targetMatrix;

        public void Print()
        {
            {
                Console.WriteLine("Array state:");
                for (int i = 0; i < targetMatrix.Length; i++)
                {
                    Console.WriteLine($"Id {targetMatrix[i].Id} Name {targetMatrix[i].Name} ");
                }
                Console.WriteLine();
            }
        }


        public Sorter(Something [] targetMatrix)
        {
            this.targetMatrix = targetMatrix;
        }

        public void Swap(int first, int second)                 //usual swap
        {
            Something bufferValue = targetMatrix[first];
            targetMatrix[first] = targetMatrix[second];
            targetMatrix[second] = bufferValue;
        }

        public abstract void Sort();
      
    }
}
