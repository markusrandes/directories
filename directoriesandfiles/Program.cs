using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace directoriesandfiles
{
    class Program
    {
        static void Main(string[] args)
        {
          string rootpath = @"C:\Users\opilane\sample";
            string[] allDirectories = Directory.GetDirectories(rootpath);
            ReadArry(allDirectories);

            string[] includenestedDirectories = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
     
           
        }
        public static void ReadArry(string[] array)
        { 
        foreach(string line in array )
        }


    }
}
