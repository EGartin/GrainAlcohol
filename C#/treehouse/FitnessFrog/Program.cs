using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            //Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");
            string entry = System.Console.ReadLine();

            //Add minutes exercised to total
            //Display total minutes exercised to screen
            Console.WriteLine("You've entered " + entry + " minutes");
            //Repeat until the user quits
        }
    }
}
