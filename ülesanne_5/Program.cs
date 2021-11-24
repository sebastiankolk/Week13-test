using System;
using System.IO;

namespace ülesanne_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples\kasutajaKaust\funfacts.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            Console.WriteLine(dataFromFile[0]);
            Console.WriteLine("How many jokes would you like to see?");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            GetJokes(usernumber);
        }
        private static void GetJokes(int Factsnumber)
        {
            string filepath = @"C:\Users\opilane\samples\kasutajaKaust\funfacts.txt";
            string[] funfacts = File.ReadAllLines(filepath);

            if (Factsnumber > funfacts.Length)
            {
                Factsnumber = funfacts.Length;
            }


            for (int i = 1; i < Factsnumber; i++)
            {
                Console.WriteLine(funfacts[i]);
            }
        }
    }
}