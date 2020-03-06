using System;

namespace _9.Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDataStore strStore = new StringDataStore();
            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";
            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);



            DataStore<string> names = new DataStore<string>(5);
            names[0] = "Steve";
            names[1] = "Bill";
            names[2] = "James";
            names[3] = "Ram";
            names[4] = "Andy";
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
        }
    }
}
