using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Marks to get your Grade:");
            int Marks = Int16.Parse(Console.ReadLine());
            {
                if (Marks <= 100) { }
            }
            Console.WriteLine("Grade A");
            {
                if (Marks <= 80) { }
            }
            Console.WriteLine("Grade B");
            {
                if (Marks <= 60) { }
            }
            Console.WriteLine("Grade C");
            {
                if (Marks <= 50) { }
            }
            Console.WriteLine("Grade D");
            {

   
                 else if (Marks <= 40) { }
            }
            Console.WriteLine("FAIL");
 
        }
    }
}
