/*
 Programmer: Nami Huyen Tram
 Date: 9/19/2019
 Comments: Class Project - Deliverable 3 - Arrays 
 */

using System;

namespace Class_Project___Deliverable_3___Arrays___Nami_Huyen_Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the try catch to prevent crashing the program.
            try
            {
                // app talks
                Console.WriteLine("What should I add to make this array homework extra?");
                Console.ReadKey(true);
                Console.WriteLine("I am not asking you. I am just talking to myself...");
                Console.ReadKey(true);
                Console.WriteLine("Ok...");
                Console.ReadKey(true);
                Console.WriteLine("I don't knowwwwww ahuhuhu T____T");
                Console.ReadKey(true);
                Console.WriteLine("Let's just look at this!");
                Console.ReadKey(true);
                // The manually populated array
                int[] meow = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                               15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
                // Iterate through the array with a Foreach Loop
                foreach (int i in meow)
                {
                    Console.WriteLine("Element value = " + i);
                }
                Console.WriteLine("That's it! Now you can press any key to exit the progam.");
                Console.ReadKey();
            } // End of try
            catch
            {
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch
        }
    }
}
