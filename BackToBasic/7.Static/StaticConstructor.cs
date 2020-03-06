using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Static
{
    public static class MyStaticConstructor
    {
        static MyStaticConstructor()      // TIPS: Run only once
        {
            Console.WriteLine("Inside static constructor.");
        }
        public static int myStaticVariable = 0;

        public static void myStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        public static int MyStaticProperty { get; set; }

    }
}
