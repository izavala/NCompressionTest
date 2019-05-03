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
            var folder = Path.GetDirectoryName(inputFileName) ?? Directory.GetCurrentDirectory();
            var file = Path.GetFileName(inputFileName);
            dataDirectoryA = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(dataDirectoryA);
            ZipFile.ExtractToDirectory(inFileName, dataDirectoryA);
            var outputFileName = Path.Join(folder, "modified-" + file);
            ZipFile.CreateFromDirectory(dataDirectoryA, outputFileName);
        }
    }
}
