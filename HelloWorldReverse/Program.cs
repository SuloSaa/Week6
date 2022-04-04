using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog kuvab lause " Hello World" tagurpidi;

            
            string hWorld = "Hello World";

            for (int i = hWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(hWorld[i]);
            }
        }
    }
}
