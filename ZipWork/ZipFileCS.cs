using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace ZipWork
{
    public class ZipFileCS
    {
        //Constructor method
        public ZipFileCS()
        {
            //Constructor code
        }

        //Count the number of files inside the zip file
        public int NumberOfFiles()
        {
            int wFileCount = 0;
            String FilePath = wPath;


            if (!File.Exists(FilePath)) {
                wInfo = "Incorrect filename.";
                return 0;
            }

            try
            {
                using (ZipArchive csZipArchive = ZipFile.OpenRead(FilePath))
                {
                    foreach (var entry in csZipArchive.Entries)
                    {
                        if (!string.IsNullOrEmpty(entry.Name))
                            wFileCount += 1;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                wInfo = "Warning: Authorization required to open that file/object.";
            }
            finally
            {
                if (wInfo.Length > 0)
                    wFileCount = 0;
            }

            return wFileCount;
        }

        // Private fields only accessible by property
        private string wPath;
        private string wInfo;

        public string ZipFilePath
        {
            get { return wPath; }
            set { wPath = value; }

        }

        public string MoreInfo
        {
            get { return wInfo; }
        }

    }

}
