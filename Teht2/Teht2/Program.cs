using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Exist
            //string curFile = @"c:\testi.txt";
            //Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
            string[] lines = System.IO.File.ReadAllLines(@"C:\testi.txt");
            System.Console.WriteLine("Contents of testi.txt:\n" + lines[0]);
            Console.ReadKey();
        }
    }
}
