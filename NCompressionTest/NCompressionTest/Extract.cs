using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace NCompressionTest
{
    public class Extract
    {
        readonly string inFileName;
        readonly string dataDirectoryA;

        public Extract(string inputFileName)
        {
            inFileName = inputFileName;
            dataDirectoryA = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(dataDirectoryA);
            ZipFile.ExtractToDirectory(inFileName, dataDirectoryA);
            Console.WriteLine("Writing Zip file to: ");
            Console.WriteLine(dataDirectoryA);
            ZipFile.CreateFromDirectory(dataDirectoryA, $"modified-{inputFileName}");
        }
    }
}
