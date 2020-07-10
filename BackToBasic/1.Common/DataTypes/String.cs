using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Common.components
{
    public class String
    {
        public void Main()
        {
            // String as char Array
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            string strAsCharArr = new string(chars);

            // Escape Char \
            string escapeChar = "This is \\some\" string";

            // Escape Sequence (Alternative for escape char \)
            string path = @"\\mypc\shared\project";

            // Multi-line String
            string multiLine = @"this is a \
                multi line \
                string";

            // String concat
            string agent = "Mr." + "James";

            // String interpolation
            string fullName = $"Mr. {agent}";
        }
    }
}
