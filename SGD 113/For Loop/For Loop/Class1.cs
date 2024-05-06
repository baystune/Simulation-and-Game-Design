using System;

namespace ArrayDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an array with 6 elements
            string[] elements = new string[] { "1.90", "Grass", "Square", "$$$$", "Mango", "189" };

            //for loop displays array elements
            for (int i = 0; i < elements.Length; i++)//length of for loop is equal to elements
            {
                Console.WriteLine(elements[i]);//prints out each element in the array
            }

            Console.ReadLine();
        }
    }
}
