using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{
    class Program
    {
        static void Main(string[] args)
        {

            Kaczka dzika = new DzikaKaczka();
            dzika.wykonajKwacz();
            dzika.wykonajLeć();
            Console.ReadLine();
            Kaczka model = new ModelKaczki();
            model.wykonajLeć();
            model.ustawLatanieInterfejs(new LotzNapędemRakietowym());
            model.wykonajLeć();
            Console.ReadLine();

        }
    }
}
