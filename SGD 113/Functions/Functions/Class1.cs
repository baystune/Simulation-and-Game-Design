using System;

class Program
{
    public static void Main(string[] args)
    {
        // Calling both functions and printing the output to the console
        int resultMultiplyNumbers = MultiplyNumbers(34, 4);//stores results in new variable
        Console.WriteLine($"34 * 4: {resultMultiplyNumbers}");//prints results to console with a message

        int resultAddNumbers = AddNumbers(12, 22);//stores results in new variable
        Console.WriteLine($"12 + 22: {resultAddNumbers}");//prints results to console with a message
    }

    // Function to multiply two numbers
    public static int MultiplyNumbers(int a, int b)//names funcation and declares variables
    {
        return a * b;//returns the answer of two numbers being multiplied 
    }

    // Function to add two numbers
    public static int AddNumbers(int a, int b)//names funcation and declares variables
    {
        return a + b;//returns the sum of two numbers
    }
}
