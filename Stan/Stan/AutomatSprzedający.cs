using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    public class AutomatSprzedający
    {
        Stan stanBrakGum;
        Stan stanNieMaMonety;
        Stan stanJestMoneta;
        Stan stanGumaSprzedana;
        Stan stanWygrana;
        Stan stan;
        int liczba = 0;

        public Stan pobierzStanWygrana()
        {
            return stanWygrana;
        }

        public Stan pobierzStanBrakGum()
        {
            return stanBrakGum;
        }
        public Stan pobierzStanNieMaMonety()
        {
            return stanNieMaMonety;
        }
        public Stan pobierzStanJestMoneta()
        {
            return stanJestMoneta;
        }
        public Stan pobierzStanGumaSprzedana()
        {
            return stanGumaSprzedana;
        }


        public int pobierzLiczba()
        {
            return liczba;
        }

        public AutomatSprzedający(int liczbaGum)
        {
            stanBrakGum = new StanBrakGum(this);
            stanNieMaMonety = new StanNieMaMonety(this);
            stanJestMoneta = new StanJestMoneta(this);
            stanGumaSprzedana = new StanGumaSprzedana(this);
            stanWygrana = new StanWygrana(this);

            this.liczba = liczbaGum;
            if(liczbaGum>0)
            {
                stan = stanNieMaMonety;
            }
            else
            {
                stan = stanBrakGum;
            }

        }

        public void włóżMonetę()
        {

            stan.włóżMonetę();

        }

        public void zwróćMonetę()
        {
            stan.zwróćMonetę();
        }



        public void przekręćGałkę()
        {
            stan.przekręćGałkę();
            stan.wydaj();

        }


        public void ustawStan(Stan stan)
        {
            this.stan = stan;
        }



        public void zwolnijGumę()
        {
            Console.WriteLine("Wypada guma");
            if(liczba!=0)
            {
                liczba = liczba - 1;
            }
        }


        


        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string text = "Automaty sprzedające SA \n" + "Zapas " + liczba +"\n"+ "Stan automatu ... " + stan.ToString()+"\n";

            return text;
        }

    }
}
