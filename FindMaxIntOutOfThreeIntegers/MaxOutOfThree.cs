using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum.FindMaxOutOfThree
{
    public class MaxOutOfThree
    {
        public static int maxIntNumber()
        {
            Console.WriteLine("Enter three integers ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if((num1.CompareTo(num2)>0 && num1.CompareTo(num3)>0) ||
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