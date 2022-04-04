using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog asendab kõik 'o' tähed lauses "Dont Panic" '0' ja kõik 'a' tähed nr '4'

            string dPanic = "Dont Panic";
            dPanic = dPanic.Replace('o', '0');
            dPanic = dPanic.Replace('a', '4');
            Console.WriteLine(dPanic);

        }
    }
}
