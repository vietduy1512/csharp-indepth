using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Tuples
{
    class ValueTupleExample
    {
        public void Main()
        {
            // ValueTuple Initialization
            (int, string, string) person1 = (1, "Steve", "Jobs");
            var person2 = (1, "Steve", "Jobs");

            // Tuple requires at least two values. The following is NOT a tuple
            var number = (1);  // int type, NOT a tuple

            // Named Members
            (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
            _ = person.Id;   // returns 1
            _ = person.FirstName;  // returns "Bill"
            _ = person.LastName; // returns "Gates"

            // Assign member name with values
            var personA = (Id: 1, FirstName: "Bill", LastName: "Gates");
            
            // Note*
            // PersonId, FName, LName will be ignored.
            (int Id, string FirstName, string LastName) personB = (PersonId: 1, FName: "Bill", LName: "Gates");
            // PersonId, FirstName, LastName will be ignored. It will have the default names: Item1, Item2, Item3.
            //(string, string, int) personC = (PersonId: 1, FName: "Bill", LName: "Gates");

            // Deconstruction
            (int Id, string FirstName, string LastName) = personA;
            FirstName = LastName;
        }
    }
}
