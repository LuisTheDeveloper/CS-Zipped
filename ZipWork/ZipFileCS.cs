using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;

namespace ZipFiles
{
    public class ZipFileCS
    {
        //Constructor method
        public ZipFileCS()
        {
            //Constructor code
        }


        public int NumberOfFiles()
        {
            int wFileCount = 0;
            String FilePath = wPath;

            using (ZipArchive csZipArchive = ZipFile.OpenRead(FilePath))
            {
                foreach (var entry in csZipArchive.Entries)
                {
                    if (!string.IsNullOrEmpty(entry.Name))
                        wFileCount += 1;
                }
            }
            return wFileCount;
        }

        // Private field only accessable by property
        private string wPath;

        public string ZipFilePath
        {
            get { return wPath; }
            set { wPath = value; }

        }

    }

}
