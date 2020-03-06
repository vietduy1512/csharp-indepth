using System;

namespace _4.DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            // dynamic type (avoids compile time type checking)
            dynamic dynamicVariable = 1;
            Console.WriteLine(dynamicVariable.GetType().ToString());    // output: System.Int32


            // 1. The dynamic types are resolved at runtime instead of compile time.
            // 2. The compiler skips the type checking for dynamic type. So it doesn't give any error about dynamic types at compile time.
            // 3. The dynamic types do not have intellisense support in visual studio.
            // 4. A method can have parameters of the dynamic type.
            // 5. An exception is thrown at runtime if a method or property is not compatible.
        }
    }
}
