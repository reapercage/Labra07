using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool jatketaan = true;
                List<string> lines = new List<string>();
                string line;
                while (jatketaan)
                {
                    Console.Write("Gimme your line (exg to exit) > ");
                    line = Console.ReadLine();
                    if (line == "exg")
                    {
                        jatketaan = false;
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
                //tiedostoon kirjoittaminen
                System.IO.StreamWriter tiedosto = new System.IO.StreamWriter("lines.txt");
                foreach (string laini in lines)
                {
                    tiedosto.WriteLine(laini);
                }
                tiedosto.Close();
                //tiedoston lukeminen
                string text = System.IO.File.ReadAllText("lines.txt");
                System.Console.WriteLine("\nlines.txt:\n" + text);
                Console.ReadKey();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
