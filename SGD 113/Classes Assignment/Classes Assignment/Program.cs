using System;

class Program
{
    static void Main()
    {
        //Creates an instance of Class1
        Class1 myObject = new Class1();

        //Calls the functions using the instance and dot operator
        int sum = myObject.AddNumbers(13, 222);//values for class
        Console.WriteLine("13 + 222: " + sum);//prints additon class results to console

        myObject.PrintMessage("HELLO WORLD!");//prints message class to console

        double result = myObject.DivideNumbers(124.2, 3);//values for class
        Console.WriteLine("124.2 divided by 3: " + result);//prints divsion class results to console

        Console.ReadLine();
    }
}
