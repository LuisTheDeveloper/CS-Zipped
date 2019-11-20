using System;

namespace ZipFiles
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ZipFileCS myZip = new ZipFileCS();

            myZip.ZipFilePath = "C:/twix/SSP MTA EDI messages 20.11.19.zip";
            int wFileCount = myZip.NumberOfFiles();
            Console.WriteLine($"The zip file:{myZip.ZipFilePath} has {wFileCount} files inside.");
            Console.ReadLine();
        }
    }
}