using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class Sorter <T> : ISorter <T>
    {
        protected T [] targetMatrix;

        public void Print()
        {
            {
                Console.WriteLine("Array state:");
                for (int i = 0; i < targetMatrix.Length; i++)
                {
                    Console.Write(targetMatrix[i]+" ");
                }
                Console.WriteLine();
            }
        }


        public Sorter(T [] targetMatrix)
        {
            this.targetMatrix = targetMatrix;
        }

        public void Swap(int first, int second)                 //usual swap
        {
            T bufferValue = targetMatrix[first];
            targetMatrix[first] = targetMatrix[second];
            targetMatrix[second] = bufferValue;
        }

        public abstract void Sort();
      
    }
}
