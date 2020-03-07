using System;

namespace _13.Events
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void MainTemp()
        {
            // Advantages: only exposes the 'add' and 'remove' methods
            // modifying how the delegate can be accessed
            PrintHelper _printHelper = new PrintHelper();
            _printHelper.beforePrintEvent += DoSth;

            _printHelper.PrintMoney(1);
        }

        public void DoSth()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }
    }
}
