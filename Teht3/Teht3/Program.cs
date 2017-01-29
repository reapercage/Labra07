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
            bool jatka = true;
            string luku;
            int kokonaisluku;
            double reaali;
            bool onLuku = true;
            bool onReaali = false;

            while(jatka)
            {
                Console.Write("Anna luku > ");
                luku = Console.ReadLine();
                //if luku contains dot => double else if luku on numero => int else end
                foreach (char c in luku)
                {
                    if (c < '0' || c > '9')
                    {
                        onLuku = true;
                        //return false;
                    }
                    else
                    {
                        onLuku = false;
                    }
                }
                if (onLuku == true)
                {
                    foreach (char c in luku)
                    {
                        if (c == '.' || c == ',')
                        {
                            onReaali = true;
                        }
                    }
                }
                if (onReaali == true)
                {
                    reaali = System.Convert.ToDouble(luku);
                }
                else if (onLuku == true)
                {
                    kokonaisluku = System.Convert.ToInt32(luku);
                }
                else
                {
                    //lopeta
                    jatka = false;
                }
            }
            Console.WriteLine("Lopetetaan...");
            Console.ReadKey();
        }
    }
}
