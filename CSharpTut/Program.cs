using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.WriteLine($"This is the current time {DateTime.Now}");

            for (int i=0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg {i} is: {args[i]}");
            }


            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(", ", myArgs));

            SayHello();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
