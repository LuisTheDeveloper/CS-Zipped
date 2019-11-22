using System;


namespace ZipWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string ZipPath;
            string XlsPath;

            Console.WriteLine("Insert complete path for the Excel file:");
            XlsPath = Console.ReadLine();
            
            Console.WriteLine("Insert complete path for the zip file:");
            ZipPath = Console.ReadLine();

            ZipFileCS myZip = new ZipFileCS();
            myZip.ZipFilePath = ZipPath;
            int wFileCount = myZip.NumberOfFiles();

            if (wFileCount == 0)
                Console.WriteLine($"{myZip.MoreInfo}");
            else
                Console.WriteLine($"The zip file:{myZip.ZipFilePath} has {wFileCount} files inside.");

        }
    }
}