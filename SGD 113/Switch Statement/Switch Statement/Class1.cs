using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your favorite shape?");//prints question to console
        string playerInput = Console.ReadLine();//reads the input and puts it in a variable

        switch (playerInput.ToLower())//checks the value of the users input without it being cas senstive
        {
            case "triangle"://case 1
                Console.WriteLine("Triangles are the best");//out puts message based on case picked
                break;
            case "square"://case 2
                Console.WriteLine("Don't be a square");//out puts message based on case picked
                break;
            case "circle"://case 3
                Console.WriteLine("I'll see you around");//out puts message based on case picked
                break;
            default://default case
                Console.WriteLine("Really? Ok");//out puts message based on case picked
                break;
        }
    }
}
