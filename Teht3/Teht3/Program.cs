using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool jatka = true;
            string luku;
            int kokonaisluku;
            double reaali;
            bool onLuku = true;
            bool onReaali = false;
            bool tyhjä = false;

            List<int> kokonaisluvut = new List<int>();
            List<double> reaaliluvut = new List<double>();

            while(onLuku == true)
            {
                Console.Write("Anna luku > ");
                luku = Console.ReadLine();
                //. ei toimi if . muuta se ,

                if (luku == "exit")
                {
                    onLuku = false;
                    break;
                }
                else
                {
                    foreach (char c in luku)
                    {
                        if (c == null || c == '.')
                        {
                            onLuku = false;
                        }
                    }
                    foreach (char c in luku)
                    {
                        if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '.' || c == ',')
                        {
                            onLuku = true;
                            //return false;
                        }
                        else
                        {
                            onLuku = false;
                            break;
                        }
                    }
                    foreach (char c in luku)
                    {
                        if (c == '.' || c == ',')
                        {
                            onReaali = true;
                        }
                    }
                    if (onReaali == true)
                    {
                        reaali = System.Convert.ToDouble(luku);
                        reaaliluvut.Add(reaali);
                    }
                    else
                    {
                        kokonaisluku = System.Convert.ToInt32(luku);
                        kokonaisluvut.Add(kokonaisluku);
                    }
                }
                
            }
            //tiedostoon kirjoittaminen
            System.IO.StreamWriter tiedosto = new System.IO.StreamWriter("kokonaisluvut.txt");
            foreach (int lupu in kokonaisluvut)
            {
                tiedosto.WriteLine(lupu);
            }
            tiedosto.Close();
            System.IO.StreamWriter tiedosto2 = new System.IO.StreamWriter("reaaliluvut.txt");
            foreach (double tupu in reaaliluvut)
            {
                tiedosto2.WriteLine(tupu);
            }
            tiedosto2.Close();
            Console.WriteLine("Lopetetaan...");
            Console.ReadKey();
        }
    }
}
