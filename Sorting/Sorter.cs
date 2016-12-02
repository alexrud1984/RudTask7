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

        public Sorter(T[] targetMatrix)
        {
            this.targetMatrix = targetMatrix;
        }

        public void Print()
        {
            {
                for (int i = 0; i < targetMatrix.Length; i++)
                {
                    Console.WriteLine(targetMatrix[i].ToString());
                }
                Console.WriteLine();
            }
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
