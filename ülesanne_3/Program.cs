using System;
using System.Collections.Generic;
using System.IO;

namespace ülesanne_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string toyota = @"C:\Users\opilane\samples\kasutajaKaust\toyota.txt";
            string bmw = @"C:\Users\opilane\samples\kasutajaKaust\bmw.txt";
            string cars = @"C:\Users\opilane\samples\kasutajaKaust\cars.txt";
            string tesla = @"C:\Users\opilane\samples\kasutajaKaust\tesla.txt";


            List<string> toyotalist = new List<string>();
            List<string> bmwlist = new List<string>();
            List<string> teslalist = new List<string>();

            string[] data = File.ReadAllLines(cars);

            foreach (string element in data)
            {
                if (element.Contains("Toyota"))
                {
                    toyotalist.Add(element);

                }
                if (element.Contains("BMW"))
                {
                    bmwlist.Add(element);

                }
                if (element.Contains("Tesla"))
                {
                    teslalist.Add(element);

                }

                File.WriteAllLines(toyota, toyotalist);
                File.WriteAllLines(bmw, bmwlist);
                File.WriteAllLines(tesla, teslalist);

            }
        }
    }
}