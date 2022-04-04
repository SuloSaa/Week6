using System;

namespace StingAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog küsib kasutajlt sisestada kasutaja eesnimi;
            //prog kuvab kasutaja eesnime pikkust;
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");

            
        }
    }
}
