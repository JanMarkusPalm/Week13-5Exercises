using System;
using System.Collections.Generic;
using System.IO;

namespace rakendus_Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ToyotaData = @"C:\Users\opilane\samples\Samples\toyota.txt";
            string BMWData = @"C:\Users\opilane\samples\Samples\bmw.txt";
            string CarsData = @"C:\Users\opilane\samples\Samples\cars.txt";
            string TeslaData = @"C:\Users\opilane\samples\Samples\tesla.txt";

            List<string> toyota = new List<string>();
            List<string> bmw = new List<string>();
            List<string> tesla = new List<string>();

            string[] sourceData = File.ReadAllLines(CarsData);

            foreach (string element in sourceData)
            {
                if (element.Contains("Tesla"))
                {
                    tesla.Add(element);

                }
                if (element.Contains("Toyota"))
                {
                    toyota.Add(element);

                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);

                }
                File.WriteAllLines(ToyotaData, toyota);
                File.WriteAllLines(BMWData, bmw);
                File.WriteAllLines(TeslaData, tesla);

            }




        }



    }
}