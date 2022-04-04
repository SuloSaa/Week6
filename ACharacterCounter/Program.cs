using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog küsib kasutajalt sisestada ees- ja perekonnanime;
            //prog kuvab mitu "a" tähte on kasutaja ees- ja perkonnanimes kokku;


            Console.WriteLine("Palun sisesta eesnimi: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("Palun sisesta oma perekonnanimi: ");
            string LName = Console.ReadLine();

            string FullName = $"{Fname} {LName}".ToLower();
            Console.WriteLine(FullName);

            int aCounter = 0;


            for (int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {
                    Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte. ");
            }
            else
            {
                    Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte. ");
            }

            
        }
    }
}
