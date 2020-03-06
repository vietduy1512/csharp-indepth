using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Tuples
{
    class TupleExample
    {
        public void Main()
        {
            // Tuple Initialization
            // C1:
            Tuple<int, string, string> person1 = new Tuple<int, string, string>(1, "Steve", "Jobs");

            // C2:
            var person2 = Tuple.Create(1, "Steve", "Jobs");

            // Access
            _ = person1.Item1;
            _ = person1.Item2;
            _ = person1.Item3;
        }
    }
}
