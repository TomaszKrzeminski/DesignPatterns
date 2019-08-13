using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria włoska = new WłoskaPizzeria();
            Pizzeria amerykańska = new AmerykańskaPizzeria();

            Pizza pizza = włoska.zamówPizza("serowa");
            Console.WriteLine("zamówiono "+pizza.pobierzNazwa());

            pizza = amerykańska.zamówPizza("serowa");
            Console.WriteLine("Jacek zamówił "+pizza.pobierzNazwa());

            Console.ReadLine();
        }
    }
}
