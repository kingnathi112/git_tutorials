using System;

namespace Git_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please supply first number:");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please supply second number:");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{firstnumber} + {secondnumber} = {Calculator.AddTwoNumbers(firstnumber,secondnumber)}");
        }
    }
}
