using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Array
{
    class MultidimensionalArrays
    {
        public void Main()
        {
            // two-dimensional Array
            int[,] arr2d1 = new int[3, 2] 
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            // or 
            int[,] arr2d2 = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            // Access
            _ = arr2d1[0, 0];
        }
    }
}
