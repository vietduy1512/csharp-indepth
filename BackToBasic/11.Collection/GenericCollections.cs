using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Collection
{
    class GenericCollections
    {
        public void Main()
        {
            // List<T>
            var intList = new List<int>();
            intList.Add(10);
            intList.AddRange(new List<int> {1, 2, 3});

            _ = intList[0];

            // Dictionary<T1, T2>
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");

            _ = dict[1];

            // SortedList<T1, T2>
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");
            // Result is sorted: 1, 2, 3, 4, 5

            string val;
            sortedList1.TryGetValue(3, out val);
        }
    }
}
