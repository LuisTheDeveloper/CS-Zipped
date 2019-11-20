using System;


namespace ZipFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath;

            Console.WriteLine("Insert complete path for the Excel file:");
            FilePath = Console.ReadLine();
            
            Console.WriteLine("Insert complete path for the zip file:");
            FilePath = Console.ReadLine();

            ZipFileCS myZip = new ZipFileCS();
            myZip.ZipFilePath = FilePath;
            int wFileCount = myZip.NumberOfFiles();
            Console.WriteLine($"The zip file:{myZip.ZipFilePath} has {wFileCount} files inside.");


        }
    }
}