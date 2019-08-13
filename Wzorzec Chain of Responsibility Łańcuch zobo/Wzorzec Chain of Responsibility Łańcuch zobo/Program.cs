using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Chain_of_Responsibility_Łańcuch_zobo
{
    class Program
    {
        static void Main(string[] args)
        {

            Poczta s = new Spam();
            Poczta p = new Pochwała();
            Poczta sk = new Skarga();
            Poczta z = new Zapotrzebowanie();


            s.SetObject(p);
            p.SetObject(sk);
            sk.SetObject(z);


            s.ForwardRequest(TypPoczty.Brak);

            Console.ReadLine();





        }
    }
}
