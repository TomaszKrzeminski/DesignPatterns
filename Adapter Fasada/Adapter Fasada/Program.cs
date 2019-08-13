using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Fasada
{
    class Program
    {  static void testujKaczke(Kaczka kaczka)
            {
                kaczka.kwacz();
                kaczka.lataj();
            }
        static void Main(string[] args)
        {
            DzikaKaczka kaczka = new DzikaKaczka();
            DzikiIndyk indyk = new DzikiIndyk();

            Kaczka indykAdapter = new IndykAdapter(indyk);

            indyk.gulgocz();
            indyk.lataj();

            testujKaczke(kaczka);

            testujKaczke(indykAdapter);

            Console.ReadLine();
        }
    }
}
