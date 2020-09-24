using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int myRandomNumber = rnd.Next(1, 11);
            //Console.WriteLine($"Your random number is {myRandomNumber}");
            Console.WriteLine("What is my number from 1 to 10: ");
            int userGuess = Int32.Parse(Console.ReadLine());

            if(myRandomNumber == userGuess)
            {
                Console.WriteLine("Congratulations!");
            }else
            {
                Console.WriteLine($"Wrong. The right number was {myRandomNumber}");
            }
        }
    }
}
