using System;

class Program
{
    static void Main()
    {
        //ask the user a question with three options
        Console.WriteLine("Choose your Pokemon, (Bulbasaur, Squirtle, and Charmander)");

        //get input from the user
        string userInput = Console.ReadLine();

        if (userInput.Equals("Bulbasaur", StringComparison.OrdinalIgnoreCase))//user picked Bulbasaur
        {
            Console.WriteLine("You picked a grass type pokemon!");//print message to console
        }
        else if (userInput.Equals("Squirtle", StringComparison.OrdinalIgnoreCase))//user picked Squirtle
        {
            Console.WriteLine("You picked a water type pokemon!");//print message to console
        }
        else if (userInput.Equals("Charmander", StringComparison.OrdinalIgnoreCase))//user picked Charmander
        {
            Console.WriteLine("You picked a fire type pokemon!");//print message to console
        }
        else
        {
            Console.WriteLine("Wrong choice no pokemon for you!");//invalid input
        }
    }
}
