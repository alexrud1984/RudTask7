using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Something : IComparable                //something to sort
    {
        public static int Count { private set; get; }   //lets count objects to generate Id
        public int Id { private set; get; }             //obj Id
        public string Name { set; get; }                //this field we will sort

        public int CompareTo(object obj)
        {
            Something o = obj as Something;
            if (o != null)
            {
                return this.Name.CompareTo(o.Name);
            }
            else
            {
                throw new Exception("How can I compare Something with something else?");
            }
        }

        public Something()
        {
            Count++;
            Id=Count;
        }

    }
}
