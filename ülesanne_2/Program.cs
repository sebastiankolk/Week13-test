using System;
using System.IO;

namespace ülesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\kasutajaKaust";
            string fileName1 = "toyota";
            string fileName2 = "bmw";
            string fileName3 = "tesla";
            string fullfilePath1 = $@"{rootDirectory}\{fileName1}.txt";
            string fullfilePath2 = $@"{rootDirectory}\{fileName2}.txt";
            string fullfilePath3 = $@"{rootDirectory}\{fileName3}.txt";
            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists1 = File.Exists(fullfilePath1);
            bool fileExists2 = File.Exists(fullfilePath2);
            bool fileExists3 = File.Exists(fullfilePath3);
            if (fileExists1)
            {
                Console.WriteLine($"File {fileName1} already exists in {rootDirectory}");
            }
            else if (!fileExists1)
            {
                File.Create(fullfilePath1);
                Console.WriteLine($"file {fileName1} has been created");
            }
            if (fileExists2)
            {
                Console.WriteLine($"File {fileName2} already exists in {rootDirectory}");
            }
            else if (!fileExists2)
            {
                File.Create(fullfilePath2);
                Console.WriteLine($"file {fileName2} has been created");
            }
            if (fileExists3)
            {
                Console.WriteLine($"File {fileName3} already exists in {rootDirectory}");
            }
            else if (!fileExists3)
            {
                File.Create(fullfilePath3);
                Console.WriteLine($"file {fileName3} has been created");
            }
        }
    }
}