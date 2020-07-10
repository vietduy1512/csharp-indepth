using System;

namespace _18.ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.tutorialsteacher.com/csharp/csharp-extension-method

            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);
        }
    }
}
