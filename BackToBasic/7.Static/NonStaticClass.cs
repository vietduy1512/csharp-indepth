using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Static
{
    public class MyNonStaticClass
    {
        private static int myStaticVariable = 0;

        public static void MyStaticMethod() // TIPS: Static method can only access other static items.
        {
            Console.WriteLine("This is static method.");
        }

        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }
}
