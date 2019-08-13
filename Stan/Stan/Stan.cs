using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    public interface Stan
    {
        void włóżMonetę();
        void zwróćMonetę();
        void przekręćGałkę();
        void wydaj();
    }

    public class StanNieMaMonety : Stan
    {

        AutomatSprzedający automatSprzedający;

        public StanNieMaMonety(AutomatSprzedający automatSprzedający)
        {
            this.automatSprzedający = automatSprzedający;
        }

        public void przekręćGałkę()
        {
            Console.WriteLine("Zanim przekręcisz gałkę wrzuć monetę");
        }

        public void wydaj()
        {
            Console.WriteLine("Najpierw zapłać");
        }

        public void włóżMonetę()
        {
            Console.WriteLine("Moneta przyjęta");
            automatSprzedający.ustawStan(automatSprzedający.pobierzStanJestMoneta());
        }

        public void zwróćMonetę()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }
    }



    public class StanJestMoneta : Stan
    {
        AutomatSprzedający automatSprzedający;
        Random losowaWygrana = new Random();
        public StanJestMoneta(AutomatSprzedający automatSprzedający)
        {
            this.automatSprzedający = automatSprzedający;
        }

        public void przekręćGałkę()
        {
            Console.WriteLine("Obróciłeś gałkę");
            int wygrana = losowaWygrana.Next(0, 2);
            if(wygrana==0)
            {
                automatSprzedający.ustawStan(automatSprzedający.pobierzStanWygrana());
            }
            else
            {
                automatSprzedający.ustawStan(automatSprzedający.pobierzStanGumaSprzedana());
            }
           
        }

        public void wydaj()
        {
            Console.WriteLine("Nie wydano gumy");
        }

        public void włóżMonetę()
        {
            Console.WriteLine( "Nie możesz włożyć więcej niż jednej monety" );
        }

        public void zwróćMonetę()
        {
            Console.WriteLine("Moneta zwrócona");
            automatSprzedający.ustawStan(automatSprzedający.pobierzStanNieMaMonety());
        }
    }


    public class StanGumaSprzedana : Stan
    {
        AutomatSprzedający automatSprzedający;

        public StanGumaSprzedana(AutomatSprzedający automatSprzedający)
        {
            this.automatSprzedający = automatSprzedający;
        }

        public void przekręćGałkę()
        {
            Console.WriteLine("Nie dostaniesz gumy tylko dlatego że przekręciłeś drugi raz");
        }

        public void wydaj()
        {
            automatSprzedający.zwolnijGumę();
            if(automatSprzedający.pobierzLiczba()>0)
            {
                automatSprzedający.ustawStan(automatSprzedający.pobierzStanNieMaMonety());
            }
            else
            {
                Console.WriteLine("Ups koniec gum");
                automatSprzedający.ustawStan(automatSprzedający.pobierzStanBrakGum());
            }
        }

        public void włóżMonetę()
        {
            Console.WriteLine("Porszę czekać na gumę");
        }

        public void zwróćMonetę()
        {
            Console.WriteLine("Nie można zwrócić monety po przekręceniu gałki");
        }
    }


    public class StanBrakGum : Stan
    {

        AutomatSprzedający automatSprzedający;

        public StanBrakGum(AutomatSprzedający automatSprzedający)
        {
            this.automatSprzedający = automatSprzedający;
        }



        public void przekręćGałkę()
        {
            Console.WriteLine("Brak gum w maszynie");
        }

        public void wydaj()
        {
            Console.WriteLine("Nie mogę wydać brak gum");
        }

        public void włóżMonetę()
        {
            Console.WriteLine("Brak gum nie wsadzać monet");
           
        }

        public void zwróćMonetę()
        {
            Console.WriteLine("Moneta zwrócona");
           
        }
    }


    public class StanWygrana : Stan
    {
        AutomatSprzedający automatSprzedający;

        public StanWygrana(AutomatSprzedający automatSprzedający)
        {
            this.automatSprzedający = automatSprzedający;
        }

        public void przekręćGałkę()
        {
            Console.WriteLine("Nie dostaniesz gumy tylko dlatego że przekręciłeś drugi raz");
        }

        public void wydaj()
        {
            Console.WriteLine("Wygrałeś dostajesz drugą gumę");
            automatSprzedający.zwolnijGumę();

           
            if (automatSprzedający.pobierzLiczba() == 0)
            {
                automatSprzedający.ustawStan(automatSprzedający.pobierzStanBrakGum());
            }
            else
            {
                automatSprzedający.zwolnijGumę();
                if (automatSprzedający.pobierzLiczba() > 0)
                {
                    automatSprzedający.ustawStan(automatSprzedający.pobierzStanNieMaMonety());
                }
                else
                {
                    Console.WriteLine("Ups koniec gum");
                    automatSprzedający.ustawStan(automatSprzedający.pobierzStanBrakGum());
                }
            }
        }

        public void włóżMonetę()
        {
            Console.WriteLine("Porszę czekać na gumę");
        }

        public void zwróćMonetę()
        {
            Console.WriteLine("Nie można zwrócić monety po przekręceniu gałki");
        }
    }


}
