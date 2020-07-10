using System;

namespace _2.ValueType.ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type

            unsafe
            {
                // Value type: ...
                // Reference type: String, Array, Class, Delegate

                // * Pointer
                int num = 3;
                int* ptr = &num;
                Console.WriteLine("{0}", (int)ptr);
            }

            // 1. Value type stores the value in its memory space, whereas reference type stores the address of the value where it is stored.
            // 2. Primitive data types and struct are of the 'Value' type.Class objects, string, array, delegates are reference types.
            // 3. Value type passes byval by default. Reference type passes byref by default.
            // 4. Value types and reference types stored in Stack and Heap in the memory depends on the scope of the variable.
        }
    }
}
