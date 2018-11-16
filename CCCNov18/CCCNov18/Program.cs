using System;
using System.IO;

namespace CCCNov18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"C:\test.txt";
            StreamReader reader = new StreamReader(path);
            
        }
    }
}
