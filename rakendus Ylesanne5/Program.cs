
using System;
using System.IO;

namespace Chuckjokegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            Console.WriteLine("enter the nr of facts you want to see");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(usernumber);
        }
        private static void GetJokes(int Jokesnumber)
        {
            string filepath = @"C:\Users\opilane\samples\Samples\funfacts.txt";
            string[] jokesaboutChuck = File.ReadAllLines(filepath);

            if (Jokesnumber > jokesaboutChuck.Length)
            {
                Jokesnumber = jokesaboutChuck.Length;
            }

            for (int i = 0; i < Jokesnumber; i++)
            {
                Console.WriteLine(jokesaboutChuck[i]);
            }

        }
    }
}
