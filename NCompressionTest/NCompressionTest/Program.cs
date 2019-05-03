using System;

namespace NCompressionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var file = args[0];
            var x =new Extract(file);
            Console.ReadLine();
        }
    }
}
