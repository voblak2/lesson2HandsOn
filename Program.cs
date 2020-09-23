using System;

namespace lesson2HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 3;
            bool isStudent = true;

            if (age >= 65)
            {
                Console.WriteLine("Please pay $7");
            }   else if (age < 0)
            {
                Console.WriteLine("Invalid age");
            }   else if (age <= 12 || isStudent)
            {
                Console.WriteLine("Please pay $8");
            }   else
            {
                Console.WriteLine("Please pay $10");
            }
        }
    }
}
