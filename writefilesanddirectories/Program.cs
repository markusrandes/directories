using System;
using System.IO;

namespace writefilesanddirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\sample.txt";
            string directorypath = @"C:\Users\opilane\sample";

            string[] files = Directory.GetFiles(directorypath, "*.*", SearchOption.AllDirectories);

        }
    }
}
