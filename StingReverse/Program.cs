using System;

namespace StingReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // program kuvab eesnme tagurpidi
            Console.WriteLine("Sisesta eesnimi: ");
            string FirstName = Console.ReadLine();

            for(int i = FirstName.Length - 1; i >= 0; i--)
            {
                Console.Write(FirstName[i]);
            }

        }
    }
}
