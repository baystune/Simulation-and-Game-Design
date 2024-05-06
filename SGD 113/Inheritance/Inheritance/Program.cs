using System;

class Program
{
    static void Main()
    {
        // Instantiate the ParentClass object
        ParentClass parentObj = new ParentClass();

        // Access variables and functions from the parent class
        Console.WriteLine("Parent Variable: " + parentObj.ParentVariable);
        parentObj.ParentFunction();

        // Instantiate the ChildClass object
        ChildClass childObj = new ChildClass();

        // Access variables and functions from both parent and child classes
        Console.WriteLine("Child Variable (Inherited from Parent): " + childObj.ParentVariable);
        childObj.ParentFunction(); // Accessing parent class function from child object
        childObj.ChildFunction(); // Accessing child class function

        Console.ReadLine();
    }
}
