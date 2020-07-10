using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Common.components
{
    public class Numbers
    {
        public void Main()
        {
            // https://www.tutorialsteacher.com/csharp/numbers

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n",
                sizeof(byte),       // 1 byte
                sizeof(short),      // 2 bytes
                sizeof(int),        // 4 bytes
                sizeof(long),       // 8 bytes
                sizeof(float),      // 4 bytes
                sizeof(double),     // 8 bytes
                sizeof(decimal));   // 16 bytes
        }
    }
}
