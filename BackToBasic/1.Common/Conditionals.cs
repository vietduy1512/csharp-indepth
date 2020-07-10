using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Common.components
{
    public class Conditionals
    {
        public void IfCondition()
        {
            bool flag = true;
            if (flag)
            {
                // code block
            }
            else if (flag)
            {
                // code block
            }
            else
            {
                // code block
            }
        }

        public void TernaryOperator()
        {
            int x = 20, y = 10;
            var result = x > y ? x : y;
        }

        public void Switch()
        {
            int number = 1;
            switch (number)
            {
                case 1:
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }
    }
}
