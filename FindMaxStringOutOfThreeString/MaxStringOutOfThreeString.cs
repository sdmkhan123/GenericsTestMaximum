using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum.FindMaxStringOutOfThreeString
{
    public class MaxStringOutOfThreeString
    {
        public static string maxStriing()
        {
            Console.WriteLine("Enter three string ");
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            string string3 = Console.ReadLine();
            if ((string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0) ||
                (string1.CompareTo(string2) >= 0 && string1.CompareTo(string3) > 0) ||
                (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) >= 0))
            {
                return string1;
            }
            if ((string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0) ||
                (string2.CompareTo(string1) >= 0 && string2.CompareTo(string3) > 0) ||
                (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) >= 0))
            {
                return string2;
            }
            if ((string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0) ||
                (string3.CompareTo(string1) >= 0 && string3.CompareTo(string2) > 0) ||
                (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) >= 0))
            {
                return string3;
            }
            return string1;
        }
    }
}
