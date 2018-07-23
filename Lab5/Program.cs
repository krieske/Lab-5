using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string yes;
            do
            {
                Console.WriteLine("Welcome to the Factorial Calculator!");
                Console.WriteLine("Please enter a whole number between 1 and 20:");
                userInput = int.Parse(Console.ReadLine());

                while (userInput < 0)
                {
                    Console.WriteLine("Please enter a positive number.");
                    userInput = int.Parse(Console.ReadLine());
                }

                long num = Convert.ToInt64(userInput);
                long result = num;

                for (int i = 1; i < userInput; i++)
                {
                    result = result * i;
                }
                Console.WriteLine(result);
                Console.WriteLine("Do you want to go again? (yes/no)");
                yes = Console.ReadLine();
            }
            while ((yes == "yes") || (yes == "y") || (yes == "Y") || (yes == "Yes") || (yes == "YES"));
            Console.WriteLine("Goodbye!");
        }
    }
}
