using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Array
{
    class JaggedArray
    {
        public void Main()
        {
            // Jagged Arrays
            int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays 
            int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays

            // Access
            _ = jArray1[0][0];
            _ = jArray1[1];
        }
    }
}
