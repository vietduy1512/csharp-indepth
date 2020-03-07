using System;

namespace _17.Func.Action.Predicate.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void MainTemp()
        {
            // Ways to define Func
            /// Has n input parameters and one out parameter
            Func<int, int, int> add1 = Sum;
            Func<int, int, int> add2 = (x, y) => x + y;
            Func<int, int, int> add3 = delegate (int x, int y)
            {
                return x + y;
            };

            // Ways to define Action
            /// Action delegate doesn't return a value
            Action<int> act1 = SumAction;
            Action<int> act2 = (i) => { };
            Action<int> act3 = delegate (int i)
            {
                Console.WriteLine(i);
            };

            // Predicate
            /// Predicate delegate methods must take one input parameter and return a boolean - true or false
        }

        int Sum(int x, int y)
        {
            return x + y;
        }

        void SumAction(int i)
        {

        }
    }
}
