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

            //Luetaan tiedoston rivit taulukkoon
            string[] lines = System.IO.File.ReadAllLines(@"C:\testi.txt");
            int numberOfLines = lines.Length;
            List<string> nimet = new List<string>();
            List<int> nimiLukema = new List<int>();
            for(int i = 0; i < numberOfLines; i++)
            {
                if(nimet.Contains(lines[i]) == false)
                {
                    nimet.Add(lines[i]);
                    nimiLukema.Add(0);
                }
            }
            int numberOfNames = nimet.Count;
            for(int x = 0; x < numberOfNames; x++)
            {
                for(int i = 0; i < numberOfLines; i++)
                {
                    if (lines[i] == nimet[x])
                    {
                        nimiLukema[x]++;
                    }
                }
            }
            //
            Console.WriteLine("Tiedosto testi.txt sisältää " + numberOfLines + " riviä ja "
                               + nimet.Count + " nimeä.\n");
            for(int i = 0; i < nimet.Count; i++)
            {
                Console.WriteLine(nimet[i] + " on kirjoitettu " + nimiLukema[i] + " kertaa");
            }
            Console.ReadKey();
        }
    }
}
