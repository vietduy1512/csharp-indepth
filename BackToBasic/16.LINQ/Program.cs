using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3 };

            var result1 = list.Where(x => x == 1);
        }
    }
}
