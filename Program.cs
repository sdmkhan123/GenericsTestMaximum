using GenericsTestMaximum.FindMaxOutOfThree;
using GenericsTestMaximum.FindMaxOutOfThreeFloat;
using GenericsTestMaximum.FindMaxStringOutOfThreeString;
using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Welcome to Generics Test Maximum");
            Console.WriteLine("***************************************************************");
            while (true)
            {
                Console.WriteLine("Press 1 : to comapre 3 int\nPress 2 : to comparre 3 float\nPress 3 : to compare 3 string\nPress 8 : to exit");
                Console.WriteLine("***************************************************************");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        int intNum = MaxOutOfThree.maxIntNumber();
                        Console.WriteLine("max int out of 3 int is :--> " + intNum);
                        break;
                    case 2:
                        double floatNum = MaxOutOfThreeFloat.maxFloatNumber();
                        Console.WriteLine("max float num out of 3 float num is :--> " + floatNum);
                        break;
                    case 3:
                        string maxStr = MaxStringOutOfThreeString.maxStriing();
                        Console.WriteLine("max string out of 3 string is :--> " + maxStr);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("***************************************************************");
            }
        }
    }
}
