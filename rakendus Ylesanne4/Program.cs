using System;
using System.Collections.Generic;
using System.IO;

namespace rakendus_Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the car brand you'd like to view models of");

            string userselection = Console.ReadLine();

            string targetFile = $@"C:\Users\opilane\samples\Samples\{userselection}.txt";
          



            string[] dataFromFile = File.ReadAllLines(targetFile);

            
           
            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
               
            }

           
        }
    }
}
