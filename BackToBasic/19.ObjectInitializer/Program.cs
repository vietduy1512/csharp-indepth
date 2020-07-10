using System;

namespace _19.ObjectInitializer
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer
            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };
        }
    }
}
