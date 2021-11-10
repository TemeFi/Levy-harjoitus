using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levyt
{
    class Program
    {
        static void Main(string[] args)
        {

            // Teemu Karhunen
            int dvdmaara = 0;
            int brmaara = 0;
            int mdmaara = 0;
            int kokomaara = 0;

            int dvdhinta = 0;
            int brhinta = 0;
            int mdhinta = 0;
            int kokohinta = 0;

            string vastaus;

            Console.WriteLine("Ostatko DVD levyjä? 6 Euroa per levy. Y/N?");
            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            if (vastaus == "Y")
            {
                Console.WriteLine("Montako levyä ostat?");
                dvdmaara = int.Parse(Console.ReadLine());
                dvdhinta = 6 * dvdmaara;

            }

            Console.WriteLine("Ostatko BluRay levyjä?  10 Euroa per levy.  Y/N?");

            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            if (vastaus == "Y")
            {
                Console.WriteLine("Montako levyä ostat?");
                brmaara = int.Parse(Console.ReadLine());
                brhinta = 10 * brmaara;
            }

            Console.WriteLine("Ostatko MiniDisk levyjä?  8 Euroa per levy.  Y/N?");

            vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();

            if (vastaus == "Y")
            {
                Console.WriteLine("Montako levyä ostat?");
                mdmaara = int.Parse(Console.ReadLine());
                mdhinta = 8 * mdmaara;

            }
            kokomaara = dvdmaara + brmaara + mdmaara;
            kokohinta = dvdhinta + brhinta + mdhinta;

            Console.WriteLine("Ostit " + kokomaara + " levyä");
            Console.WriteLine("Näistä " + dvdmaara + " oli DVD levyjä, " + brmaara + " BluRay levyjä ja " + mdmaara + " MiniDisk levyjä.");
            Console.WriteLine("DVD hinnaksi tuli " + dvdhinta + " euroa. BluRay hinnaksi " + brhinta + " euroa. MiniDisk hinnaksi " + mdhinta + " euroa.");
            Console.WriteLine("Kokonais hinta on " + kokohinta + " euroa.");

            Console.ReadKey();
        }
    }
}
