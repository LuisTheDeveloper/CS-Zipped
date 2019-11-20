using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ZipWork
{
    class Work_Excel
    {
        public static void readExcelFile(string FilePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWrkBook = xlApp.Workbooks.Open(FilePath);


            xlWrkBook.Close();
            xlApp.Quit();
        }
    }
}
