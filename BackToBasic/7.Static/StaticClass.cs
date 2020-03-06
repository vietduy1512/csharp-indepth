using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Static
{
    public static class MyStaticClass
    {
        public static int myStaticVariable = 0;

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        public static int MyStaticProperty { get; set; }
    }
}
