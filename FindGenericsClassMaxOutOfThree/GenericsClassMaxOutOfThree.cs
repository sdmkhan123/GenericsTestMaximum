using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum.FindGenericsClassMaxOutOfThree
{
    public class GenericsClassMaxOutOfThree <T> where T : IComparable
    {
        public T input1, input2, input3;
        public GenericsClassMaxOutOfThree(T input1, T input2, T input3) 
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
        }
        public static UT genericClassmaxOutOfThree<UT>(UT input1, UT input2, UT input3) where UT : IComparable
        {
            if ((input1.CompareTo(input2) > 0 && input1.CompareTo(input3) > 0) ||
                (input1.CompareTo(input2) >= 0 && input1.CompareTo(input3) > 0) ||
                (input1.CompareTo(input2) > 0 && input1.CompareTo(input3) >= 0))
            {
                return input1;
            }
            if ((input2.CompareTo(input1) > 0 && input2.CompareTo(input3) > 0) ||
                (input2.CompareTo(input1) >= 0 && input2.CompareTo(input3) > 0) ||
                (input2.CompareTo(input1) > 0 && input2.CompareTo(input3) >= 0))
            {
                return input2;
            }
            if ((input3.CompareTo(input1) > 0 && input3.CompareTo(input2) > 0) ||
                (input3.CompareTo(input1) >= 0 && input3.CompareTo(input2) > 0) ||
                (input3.CompareTo(input1) > 0 && input3.CompareTo(input2) >= 0))
            {
                return input3;
            }
            return input1;
        }
    }
}
