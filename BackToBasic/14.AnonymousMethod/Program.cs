using System;

namespace _14.AnonymousMethod
{
    class Program
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            // JS: function() {}
            // C#: delegate() {}
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };
        }
    }
}
