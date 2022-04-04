using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // prog ennustab mis juhtub kasutajaga homme (rndomig)

            string[] prediction = { "win a million", "fall in love", "buy youtube premium", "joine the dark side for cookies" };

            Random rnd = new Random();
            int userNumber = rnd.Next(0, prediction.Length);

            Console.WriteLine($"today you wil have {prediction[userNumber]}");
        }
    }
}
