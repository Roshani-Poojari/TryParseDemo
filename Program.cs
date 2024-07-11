using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            if (int.TryParse(Console.ReadLine(), out int myNumber))
            {
                int squareNumber = myNumber * myNumber;
                Console.WriteLine("Square of "+myNumber+" is: " + squareNumber);
            }
            else
                Console.WriteLine("Invalid input! Enter a number!!!");
        }
    }
}
