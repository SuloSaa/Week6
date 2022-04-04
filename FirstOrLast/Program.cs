using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            // program küsib kasutajalt sisestada oma ees- ja prekonnanimed;
            // program loeb andmete pikkust;
            // program kuvab kumb nendest on pikem kas ees- või prekonnanimed;

            // kasuta if 

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");

            Console.WriteLine("Sisesta perekonnanmi:");
            string lastName= Console.ReadLine();
            Console.WriteLine($"Sinu eesnimes on {lastName.Length} sümbolit.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Eesnimi on kõige pikem.");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Perekonnanimi on kõige pikem");
            }

        }
    }
}
