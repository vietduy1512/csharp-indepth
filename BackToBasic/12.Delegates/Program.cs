using System;

namespace _12.Delegates
{
    class Program
    {
        // declare delegate
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            // Using Delegate
            Print printDel1;
            printDel1 = PrintNumber;
            printDel1 = PrintMoney;

            // Access Delegate
            printDel1(100000);       // or
            printDel1.Invoke(10000);


            // Delegate parameter
            void PrintHelper(Print delegateFunc, int numToPrint)
            {
                delegateFunc(numToPrint);
            }
            PrintHelper(PrintNumber, 10000);


            // Multicast delegate
            Print printDel2 = PrintNumber;
            printDel2 += PrintHexadecimal;
            printDel2 += PrintMoney;
            printDel2(1000); // invoke all 3 methods sequentially
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
