using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter your age: ");
            //int drivingAge = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;

            do
            {
                Console.Write("Guss a number between 1 and 10:");
                numberGuessed = int.Parse(Console.ReadLine());

            }
            while (secretNumber != numberGuessed);

            Console.Write($"You guessed the secret number: {secretNumber}");

            Console.ReadLine();

        }




    }
}
