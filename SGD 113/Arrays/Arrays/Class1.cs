using System;

namespace FruitNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an array filled with fruits 
            string[] fruits = { "Starfruit", "Banana", "Grapefruit", "Kiwi", "Peaches", "Plum" };

            //use foreach loop to display each fruit in list format
            Console.WriteLine("List of available fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);//writes the fruit to the console
            }

            Console.ReadLine();
        }
    }
}
