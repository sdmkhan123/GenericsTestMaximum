using GenericsTestMaximum.FindMaxOutOfThree;
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
                Console.WriteLine("Press 1 : to comapre 3 int\nPress 8 : to exit");
                //Press 2 : to comparre 3 float\nPress 3 : to compare 3 string
                Console.WriteLine("***************************************************************");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        int num = MaxOutOfThree.maxIntNumber();
                        Console.WriteLine("max int out of 3 int is :--> " + num);
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
