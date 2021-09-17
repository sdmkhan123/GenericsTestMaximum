using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum.FindMaxOutOfThreeFloat
{
    public class MaxOutOfThreeFloat
    {
        public static double maxFloatNumber()
        {
            Console.WriteLine("Enter three float number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            if ((num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0) ||
                (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0) ||
                (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0))
            {
                return num1;
            }
            if ((num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0) ||
                (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0) ||
                (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0))
            {
                return num2;
            }
            if ((num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0) ||
                (num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0) ||
                (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0))
            {
                return num3;
            }
            return num1;
        }
    }
}
