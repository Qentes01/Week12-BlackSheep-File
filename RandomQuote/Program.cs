using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples\quotes.txt";
            string[] dataFromfile = File.ReadAllLines(filePath);

            Console.WriteLine(dataFromfile[0]);

            Random rnd = new Random();
            int RandomIndex = rnd.Next(1, dataFromfile.Length);
            Console.WriteLine(dataFromfile[RandomIndex]);

            

            
        }
    }
}
