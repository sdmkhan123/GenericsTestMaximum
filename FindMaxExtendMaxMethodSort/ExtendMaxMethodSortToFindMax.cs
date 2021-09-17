using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum.FindMaxExtendMaxMethodSort
{
    public class ExtendMaxMethodSortToFindMax <T> where T : IComparable
    {
        // Empty Array
        public T[] value;
        //Parameter Constructor
        public ExtendMaxMethodSortToFindMax(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            Array.Reverse(values);
            return values;
        }
        //Generic method Comparing and find Max Value
        public T MaxValue(T[] values)
        {
            var sorted_values = Sort(values);
            T n = sorted_values[0];
            return n;

        }
    }
}
