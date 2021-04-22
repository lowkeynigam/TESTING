using System;

namespace NestedRepititionTask
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Exercise 1, Task 1");
           Console.WriteLine("Please enter your first name!");
           string firstname = (Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(firstname);
            }
            Console.WriteLine("Exercise 1, Task 2");
            Console.WriteLine("Enter the amount of times you want your first name to be printed");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(firstname);
            }

            string result;
            for (int i = 1; i <= 5; i++)
            {
                result = new string('x', i);
                Console.WriteLine(result);
            }
            for (int i = 5; i >= 1; i--)
            {
                result = new String('x', i);
                Console.WriteLine(result);
            }
        }
    }
}
