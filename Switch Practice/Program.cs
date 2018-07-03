using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number please: ");
            string numberOneAsText = Console.ReadLine();
            int numberOne = Convert.ToInt32(numberOneAsText);

            Console.Write("Second number please: ");
            string numberTwoAsText = Console.ReadLine();
            int numberTwo = Convert.ToInt32(numberTwoAsText);

            Console.Write("Enter the type of operation you want to perform: ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    var additionresult = numberOne + numberTwo;
                    Console.WriteLine(additionresult);
                    Console.ReadLine();
                    break;

                case "-":
                    var subtractionresult = numberOne - numberTwo;
                    Console.WriteLine(subtractionresult);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
