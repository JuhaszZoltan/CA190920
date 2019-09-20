using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia, hogy hívnak?");
            var nev = Console.ReadLine();
            Console.WriteLine($"Oh, milyen szép név az, hogy {nev}! <3");
            Console.WriteLine("Szerecc programozni?");
            var valasz = Console.ReadLine();
            if(valasz.ToLower() == "igen")
            {
                Console.WriteLine("akkor mi nagyon jó barátok leszünk!");
            }
            else
            {
                Console.WriteLine(":(");
                Console.WriteLine("Akkor viszlát! :'(");
            }
            Console.ReadKey();
        }
    }
}
