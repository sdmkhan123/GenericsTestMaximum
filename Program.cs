using GenericsTestMaximum.FindMaxOutOfThree;
using GenericsTestMaximum.FindMaxOutOfThreeFloat;
using GenericsTestMaximum.FindMaxStringOutOfThreeString;
using GenericsTestMaximum.FindGenericsMaxOutOfThree;
using GenericsTestMaximum.FindGenericsClassMaxOutOfThree;
using GenericsTestMaximum.FindMaxExtendMaxMethodSort;
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
                Console.WriteLine("Press 1 : to comapre 3 int\nPress 2 : to comparre 3 float\nPress 3 : to compare 3 string\nPress 4 : refactor-1 Generic method for find max" +
                    "\nPress 5 : refactor-1 Generic class-constructor method for find max\nPress 6 : Extend method sort to find max\nPress 8 : to exit");
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
                    case 4:
                        Console.WriteLine("Enter three integer numbers ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("***************************************************************");
                        Console.WriteLine("Enter three float numbers ");
                        double floatNum1 = Convert.ToDouble(Console.ReadLine());
                        double floatNum2 = Convert.ToDouble(Console.ReadLine());
                        double floatNum3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("***************************************************************");
                        Console.WriteLine("Enter three string ");
                        string string1 = Console.ReadLine();
                        string string2 = Console.ReadLine();
                        string string3 = Console.ReadLine();
                        Console.WriteLine("***************************************************************");
                        int refactorIntNum = GenericsMaxOutOfThree.maxOutOfThree<int>(num1, num2, num3);
                        double refactorFloatNum = GenericsMaxOutOfThree.maxOutOfThree<double>(floatNum1, floatNum2, floatNum3);
                        string refactorMaxStr = GenericsMaxOutOfThree.maxOutOfThree<string>(string1, string2, string3);
                        Console.WriteLine("> refactor-1 Generic method, max int num is :--> " + refactorIntNum);
                        Console.WriteLine("> refactor-1 Generic method, max float num is :--> " + refactorFloatNum);
                        Console.WriteLine("> refactor-1 Generic method, max string is :--> " + refactorMaxStr);
                        break;
                    case 5:
                        Console.WriteLine("Enter three integer numbers ");
                        int rfNum1 = Convert.ToInt32(Console.ReadLine());
                        int rfNum2 = Convert.ToInt32(Console.ReadLine());
                        int rfNum3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("***************************************************************");
                        Console.WriteLine("Enter three float numbers ");
                        double rfFloatNum1 = Convert.ToDouble(Console.ReadLine());
                        double rfFloatNum2 = Convert.ToDouble(Console.ReadLine());
                        double rfFloatNum3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("***************************************************************");
                        Console.WriteLine("Enter three string ");
                        string rfString1 = Console.ReadLine();
                        string rfString2 = Console.ReadLine();
                        string rfString3 = Console.ReadLine();
                        Console.WriteLine("***************************************************************");
                        GenericsClassMaxOutOfThree <int> intObj = new GenericsClassMaxOutOfThree<int>(rfNum1, rfNum2, rfNum3);
                        GenericsClassMaxOutOfThree<double> floatOnj = new GenericsClassMaxOutOfThree<double>(rfFloatNum1, rfFloatNum2, rfFloatNum3);
                        GenericsClassMaxOutOfThree<string> stringObj = new GenericsClassMaxOutOfThree<string>(rfString1, rfString2, rfString3);
                        int refactorClassIntNum = GenericsMaxOutOfThree.maxOutOfThree<int>(rfNum1, rfNum2, rfNum3);
                        double refactorClassFloatNum = GenericsMaxOutOfThree.maxOutOfThree<double>(rfFloatNum1, rfFloatNum2, rfFloatNum3);
                        string refactorClassMaxStr = GenericsMaxOutOfThree.maxOutOfThree<string>(rfString1, rfString2, rfString3);
                        Console.WriteLine("> refactor-1 Generic method, max int num is :--> " + refactorClassIntNum);
                        Console.WriteLine("> refactor-1 Generic method, max float num is :--> " + refactorClassFloatNum);
                        Console.WriteLine("> refactor-1 Generic method, max string is :--> " + refactorClassMaxStr);
                        break;
                    case 6:
                        int[] intArray = new int[] { 21, 2, 19, 93, 88, 96, 60, 98, 78, 95, 5, 7 };
                        double[] floatArray = new double[] { 2.0, 56, 93.5, 9.6, 120.0, 420, 98.3 };
                        string[] strArray = new string[] { "string1", "apple", "house", "bridgelabz", "me", "hello" };

                        ExtendMaxMethodSortToFindMax<int> intArrObj = new ExtendMaxMethodSortToFindMax<int>(intArray);
                        ExtendMaxMethodSortToFindMax<double> floatArrOnj = new ExtendMaxMethodSortToFindMax<double>(floatArray);
                        ExtendMaxMethodSortToFindMax<string> stringArrObj = new ExtendMaxMethodSortToFindMax<string>(strArray);
                        int refactorClassIntNumArr = intArrObj.MaxValue(intArray);
                        double refactorClassFloatNumArr = floatArrOnj.MaxValue(floatArray);
                        string refactorClassMaxStrArr = stringArrObj.MaxValue(strArray);
                        Console.WriteLine("> Generic class constructor method, max int num is :--> " + refactorClassIntNumArr);
                        Console.WriteLine("> Generic class constructor method, max float num is :--> " + refactorClassFloatNumArr);
                        Console.WriteLine("> Generic class constructor method, max string is :--> " + refactorClassMaxStrArr);

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
