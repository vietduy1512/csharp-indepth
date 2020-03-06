using System;

namespace _6.PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.tutorialsteacher.com/csharp/csharp-partial-class

            // Partial class provides the ability to have a single class implementation in multiple .cs files
            var obj = new MyPartialClass();
            obj.Method1(1);
            obj.Method2(2);
        }
    }
}
