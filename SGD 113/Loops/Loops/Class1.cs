using System;

namespace ConsoleMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)
            {
                Console.Clear(); //clears console screen
                DisplayMenu();

                char entry = Console.ReadKey().KeyChar;//value for character entry
                Console.WriteLine(); //moves on to the next line after reading

                switch (entry)
                {
                    case '1':
                        Console.WriteLine("Heres your order of French Fries, DIG IN");//outputs message for option 1
                        break;
                    case '2':
                        Console.WriteLine("Heres your Pizza, ENJOY");//outputs message for option 2
                        break;
                    case '3':
                        Console.WriteLine("Heres your order of Sushi, served COLD");//outputs message for option 3
                        break;
                    case '4':
                        Console.WriteLine("Heres your order of Kale Chips, EXTRA crunchy");//outputs message for option 4
                        break;
                    case '5':
                        Console.WriteLine("Heres your order of Salmon, caught by local BEARS");//outputs message for option 5
                        break;
                    case '6':
                        Console.WriteLine("Heres your order of Milk, freshly milked");//outputs message for option 6
                        break;
                    case '7':
                        Console.WriteLine("Have a Nice day Goodbye");//outputs message for exit option
                        displayMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Please try again.");//outputs message for invalid entry
                        break;
                }

                if (displayMenu)//statement allows user to return to the menu to picked another option
                {
                    Console.WriteLine("\nWould you like to view the main menu? (Y/N)");
                    char response = Console.ReadKey().KeyChar;

                    if (response != 'Y' && response != 'y')
                    {
                        displayMenu = false;
                    }
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Menu what would you like to order?");//prints menu header
            Console.WriteLine("1. French Fries");//prints option 1 to display for the menu
            Console.WriteLine("2. Pizza");//prints option 2 to display for the menu
            Console.WriteLine("3. Sushi");//prints option 3 to display for the menu
            Console.WriteLine("4. Kale Chips");//prints option 4 to display for the menu
            Console.WriteLine("5. Salmon");//prints option 5 to display for the menu
            Console.WriteLine("6. Milk");//prints option 6 to display for the menu
            Console.WriteLine("7. Exit");//prints exit option to display for the menu
            Console.Write("Please select an option: ");//prints question to display for the menu
        }
    }
}
