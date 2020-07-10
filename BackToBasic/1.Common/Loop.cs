using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Common.components
{
    class Loop
    {
        public void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                // code block
            }
        }

        public void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                // code block
                i++;
            }
        }

        public void DoWhileLoop()
        {

            int i = 0;
            do
            {
                // code block
                i++;
            } while (i < 10);
        }
    }
}
