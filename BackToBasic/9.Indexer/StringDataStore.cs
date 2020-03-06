using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Indexer
{
    public class StringDataStore
    {
        private string[] strArr = new string[10]; // internal data storage

        public string this[int index]
        {
            get => strArr[index];

            set => strArr[index] = value;
        }
    }
}
