using System;

namespace _8.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Declaration
            int[] nums1 = new int[5];

            // Array Declaration & Initialization
            int[] nums2 = new int[5] { 10, 15, 16, 8, 6 };

            // Array without Specifying Size
            int[] nums3 = { 10, 15, 16, 8, 6 };

            // Accessing Array
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i]);
            }
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }

            // Implicitly Typed Array
            var names = new[] { "Steve", "Bill", "Ram", "Mohan" };

            // Array Methods
            var len = names.Length;
            var clone = names.Clone();
        }
    }
}
