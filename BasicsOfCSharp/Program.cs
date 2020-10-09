using System;

namespace BasicsOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }            
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumber();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }   

        private static void PrintNumber()
        {
            Console.WriteLine("PrintNumbers!");
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("This is a guessing game");
            Console.ReadLine();
        }
    }
}
