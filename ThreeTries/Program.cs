using System;

namespace ThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();
            int randomNumber = rmd.Next(1, 11);
            int UserInput;
            int counter = 0;

            while (counter < 3)
            {
                Console.WriteLine("What is you number?");
                UserInput = Int32.Parse(Console.ReadLine());
                if (randomNumber == UserInput)
                {
                    Console.WriteLine("Cougratulations!, you won!");
                    break;
                }
                else
                {
                    Console.WriteLine("try again!");
                    counter = counter + 1;
                    Console.WriteLine($"you have tried {counter} tries.");
                }

            }
        }
    }
}
