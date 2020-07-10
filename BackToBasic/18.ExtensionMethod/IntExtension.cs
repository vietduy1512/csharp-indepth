using System;
using System.Collections.Generic;
using System.Text;

namespace _18.ExtensionMethod
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
