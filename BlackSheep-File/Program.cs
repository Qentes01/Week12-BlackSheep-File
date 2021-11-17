using System;
using System.IO;

namespace BlackSheep_File
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sümbolid

            a - 4
            e - 3
            o - 0
            i - 1

           */

            string filePath = @"C:\Users\opilane\samples\blacksheep.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');
            }

            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(filePath, dataFromFile);

 
        } 

        
    }
}
