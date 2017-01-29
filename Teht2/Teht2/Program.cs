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
            int numberOfLines = lines.Length;
            //tilalle dynaaminen list
            List<string> nimet = new List<string>();
            string check = lines[0];
            nimet.Add(check);
            int namecount = 0;
            for(int i = 0; i < numberOfLines; i++)
            {
                if(check == lines[i])
                {
                    namecount++;
                }
            }
            Console.WriteLine("Tiedosto testi.txt sisältää " + numberOfLines + " riviä ja " + namecount + " " + check + " nimeä.");
            Console.WriteLine("testi.txt:\n" + lines[0]);
            Console.WriteLine("\n" + nimet[0]);
            //if string[0]
            Console.ReadKey();
        }
    }
}
