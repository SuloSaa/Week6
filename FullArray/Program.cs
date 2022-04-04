using System;

namespace FullArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog ennustab mis puuvilja kasutaja sööb;

            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };
            /*
            Console.WriteLine(fruit[0]);
            Console.WriteLine(fruit[1]);
            */

            //Console.WriteLine("enter a number between 0-4: ");
            //int userNumber = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"today you wil have {fruit[userNumber]}");



        }
    }
}
