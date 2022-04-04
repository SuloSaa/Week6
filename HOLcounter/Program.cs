using System;

namespace HOLcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // program kuvab mitu H : O  ja L tähte on sõnbas "Hello World!" 

            // to lower
            Console.WriteLine("Kirjutage tekst: Hello World");
            string Sisend=Console.ReadLine().ToLower();


            int hCouneter = 0;
            int oCouneter = 0;
            int lCouneter = 0;

            for (int i=0;i < Sisend.Length; i++)
            {
                if (Sisend[i] == 'h')
                {
                    hCouneter++;
                }
                if (Sisend[i] == 'o')
                {
                oCouneter++;
                }
                if (Sisend[i] == 'l')
                {
                    lCouneter++;
                }

                

            }
            Console.WriteLine($"{Sisend} sisaldab {hCouneter} 'h' tähete, {oCouneter} 'o' tähte ja {lCouneter} 'l' tähte.");


        }
    }
}
