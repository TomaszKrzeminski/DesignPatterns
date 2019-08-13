using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomatSprzedający automatSprzedający = new AutomatSprzedający(5);

            Console.WriteLine(automatSprzedający);

            automatSprzedający.włóżMonetę();

            automatSprzedający.przekręćGałkę();

            Console.WriteLine(automatSprzedający);

            automatSprzedający.włóżMonetę();

           

            automatSprzedający.przekręćGałkę();

           

            automatSprzedający.włóżMonetę();
            automatSprzedający.przekręćGałkę();
           
            Console.WriteLine(automatSprzedający);

            Console.ReadLine();


        }
    }
}
