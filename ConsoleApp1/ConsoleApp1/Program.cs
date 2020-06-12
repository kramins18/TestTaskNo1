using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BeautifulTexts.PrintHelloText();
            int usersMenuInput = BeautifulTexts.PrintMenuText();
            Task task = new Task();
           

            while (usersMenuInput != 0)
            {
                switch (usersMenuInput)
                {
                    case 1:  // Print Array on Screen
                        task.PrintArray();
                        break;
                    case 2:  // Largest & Smallest Values
                        task.PrintSmallestLargestValues();
                        break;
                    case 3:  // Array Ascending order
                        task.PrintArrayAscending();
                        break;
                    default:
                        Console.WriteLine("Woops! You have to chose a number from 0-3.");
                        break;
                }
                Console.Write("\n Press any key to continue ");
                Console.ReadLine();
                usersMenuInput = BeautifulTexts.PrintMenuText();
            }
            Console.Write("Press any key to exit ");
            Console.ReadLine();
        }
    }
}
