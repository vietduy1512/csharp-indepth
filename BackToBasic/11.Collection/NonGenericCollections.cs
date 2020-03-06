using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _11.Collection
{
    class NonGenericCollections
    {
        public void Main()
        {
            // ArrayList
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");

            _ = (int)arryList1[0];

            // HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");

            _ = (string)ht[2];

            // Stack
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Pop();

            // Queue
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Dequeue();
        }
    }
}
