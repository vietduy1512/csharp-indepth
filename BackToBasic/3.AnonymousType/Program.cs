using System;

namespace _3.AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous Type
            var anonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true
            };

            // Nested Anonymous Type
            var nestedAnonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true,
                anotherAnonymousType = new { nestedProperty = "Nested" }
            };

            // Scope of Anonymous Type
            // An anonymous type will always be local to the method where it is defined.

            // Anonymous Types with a LINQ Query
            // TBD


            // 1. Anonymous type can be defined using the new keyword and object initializer syntax.
            // 2. The implicitly typed variable-var, is used to hold an anonymous type.
            // 3. Anonymous type is a reference type and all the properties are read - only.
            // 4. The scope of an anonymous type is local to the method where it is defined.
        }
    }
}
