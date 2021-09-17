using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum.FindGenericsMaxOutOfThree
{
    public class GenericsMaxOutOfThree
    {
        public static T maxOutOfThree <T>(T input1, T input2, T input3) where T : IComparable
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
