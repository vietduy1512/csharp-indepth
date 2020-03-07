using System;

namespace _15.Nullable.NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable types
            int? i = null;      // or Nullable<int> i = null;

            // Null-coalescing operator (??)
            var result = i ?? 0;

            // Null conditional operator (?.)
            var result2 = i?.ToString();
        }
    }
}
