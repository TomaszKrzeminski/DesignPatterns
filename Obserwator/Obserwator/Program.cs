using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class Program
    {
        static void Main(string[] args)
        {

            DanePogodowe danePogodowe = new DanePogodowe();
            WarunkiBieżąceWyświetl warunkiBieżąceWyświetl = new WarunkiBieżąceWyświetl(danePogodowe);
            //StatystykaWyświetl statystykaWyświetl = new StatystykaWyświetl(danePogodowe);
            //PrognozaWyświetl prognozaWyświetl = new PrognozaWyświetl(danePogodowe);

            danePogodowe.ustawOdczyt(26.6f, 65, 1013f);


            Console.ReadLine();
        }
    }
}
