using Polecenie_Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie_Command
{
    public class WentylatorSufitowy
    {
        public static int Szybko = 3;
        public static int Średnio = 2;
        public static int Wolno = 1;
        public static int Wyłącz = 0;
        String lokalizacja;
        int prędkość;


        public WentylatorSufitowy(string lokalizacja)
        {
            this.lokalizacja = lokalizacja;
            prędkość = Wyłącz;
        }


        public void wysokieObroty()
        {
            prędkość = Szybko;
            Console.WriteLine(lokalizacja+" wentylator sufitowy włączony wysokie obroty");
        }

        public void średnieObroty()
        {
            prędkość = Średnio;
            Console.WriteLine(lokalizacja + " wentylator sufitowy włączony średnie obroty");
        }
        public void niskieObroty()
        {
            prędkość = Wolno;
            Console.WriteLine(lokalizacja + " wentylator sufitowy włączony wolne obroty");
        }
        public void wyłącz()
        {
            prędkość = Wyłącz;
            Console.WriteLine(lokalizacja + " wentylator sufitowy wyłączony");
        }


        public int pobierzPrędkość()
        {
            return prędkość;
        }


    }


    public class PolecenieWentylatorSufitowySzybko : Polecenie
    {
        WentylatorSufitowy wentylatorSufitowy;
        int poprzedniaSzybkość;

       public PolecenieWentylatorSufitowySzybko(WentylatorSufitowy wentylatorSufitowy)
        {
            this.wentylatorSufitowy = wentylatorSufitowy;
        }

        public void wycofaj()
        {
            poprzedniaSzybkość = wentylatorSufitowy.pobierzPrędkość();
            if(poprzedniaSzybkość==WentylatorSufitowy.Szybko)
            {
                wentylatorSufitowy.wysokieObroty();
            }
            else if(poprzedniaSzybkość==WentylatorSufitowy.Średnio)
            {
                wentylatorSufitowy.średnieObroty();
            }
            else if(poprzedniaSzybkość==WentylatorSufitowy.Wolno)
            {
                wentylatorSufitowy.niskieObroty();
            }
            else if(poprzedniaSzybkość==WentylatorSufitowy.Wyłącz)
            {
                wentylatorSufitowy.wyłącz();
            }

        }

        public void wykonaj()
        {
            poprzedniaSzybkość = wentylatorSufitowy.pobierzPrędkość();
            wentylatorSufitowy.wysokieObroty();
        }
    }

    public class PolecenieWentylatorSufitowyŚrednio : Polecenie
    {
        WentylatorSufitowy wentylatorSufitowy;
        int poprzedniaSzybkość;

        public PolecenieWentylatorSufitowyŚrednio(WentylatorSufitowy wentylatorSufitowy)
        {
            this.wentylatorSufitowy = wentylatorSufitowy;
        }

        public void wycofaj()
        {
            poprzedniaSzybkość = wentylatorSufitowy.pobierzPrędkość();
            if (poprzedniaSzybkość == WentylatorSufitowy.Szybko)
            {
                wentylatorSufitowy.wysokieObroty();
            }
            else if (poprzedniaSzybkość == WentylatorSufitowy.Średnio)
            {
                wentylatorSufitowy.średnieObroty();
            }
            else if (poprzedniaSzybkość == WentylatorSufitowy.Wolno)
            {
                wentylatorSufitowy.niskieObroty();
            }
            else if (poprzedniaSzybkość == WentylatorSufitowy.Wyłącz)
            {
                wentylatorSufitowy.wyłącz();
            }

        }

        public void wykonaj()
        {
            poprzedniaSzybkość = wentylatorSufitowy.pobierzPrędkość();
            wentylatorSufitowy.średnieObroty();
        }
    }

    public class PolecenieWentylatorSufitowyWyłącz : Polecenie
    {
        WentylatorSufitowy wentylatorSufitowy;
        int poprzedniaSzybkość;

        public PolecenieWentylatorSufitowyWyłącz(WentylatorSufitowy wentylatorSufitowy)
        {
            this.wentylatorSufitowy = wentylatorSufitowy;
        }

        public void wycofaj()
        {
            poprzedniaSzybkość = wentylatorSufitowy.pobierzPrędkość();
            if (poprzedniaSzybkość == WentylatorSufitowy.Szybko)
            {
                wentylatorSufitowy.wysokieObroty();
            }
            else if (poprzedniaSzybkość == WentylatorSufitowy.Średnio)
            {
                wentylatorSufitowy.średnieObroty();
            }
            else if (poprzedniaSzybkość == WentylatorSufitowy.Wolno)
            {
                wentylatorSufitowy.niskieObroty();
            }
            else if (poprzedniaSzybkość == WentylatorSufitowy.Wyłącz)
            {
                wentylatorSufitowy.wyłącz();
            }

        }

        public void wykonaj()
        {
            poprzedniaSzybkość = wentylatorSufitowy.pobierzPrędkość();
            wentylatorSufitowy.wyłącz();
        }
    }

    public class DrzwiGarażowe
    {
        string Text;
        public DrzwiGarażowe(string Text)
        {
            this.Text = Text;
        }
        public void doGóry()
        {
            Console.WriteLine("Unoszę drzwi do góry w "+Text);
        }

        public void naDół()
        {
            Console.WriteLine("Opuszczam drzwi na dół " + Text);
        }


    }




    public class PolecenieOtwórzDrzwiGarażowe : Polecenie
    {

        DrzwiGarażowe drzwiGarażowe;
        public PolecenieOtwórzDrzwiGarażowe(DrzwiGarażowe drzwiGarażowe)
        {
            this.drzwiGarażowe = drzwiGarażowe;
        }

        public void wycofaj()
        {
            throw new NotImplementedException();
        }

        public void wykonaj()
        {
            drzwiGarażowe.doGóry();
        }
    }

    public class PolecenieZamknijDrzwiGarażowe : Polecenie
    {

        DrzwiGarażowe drzwiGarażowe;
        public PolecenieZamknijDrzwiGarażowe(DrzwiGarażowe drzwiGarażowe)
        {
            this.drzwiGarażowe = drzwiGarażowe;
        }

        public void wycofaj()
        {
            throw new NotImplementedException();
        }

        public void wykonaj()
        {
            drzwiGarażowe.naDół();
        }
    }


    public class Światło
    {
        string Text;
        public Światło(string nazwa)
        {
            Text = nazwa;
        }
        public void włącz()
        {
            Console.WriteLine("Włączam Światło "+Text);

        }

        public void wyłącz()
        {
            Console.WriteLine("Wyłączam Światło " + Text);

        }
    }


    public interface Polecenie
    {
        void wykonaj();
        void wycofaj();

    }

    public class PolecenieWłączŚwiatło : Polecenie
    {
        Światło światło;

        public PolecenieWłączŚwiatło(Światło światło)
        {
            this.światło = światło;
        }

        public void wycofaj()
        {
            światło.wyłącz();
        }

        public void wykonaj()
        {
            światło.włącz();
        }
    }


    public class PolecenieWyłączŚwiatło : Polecenie
    {
        Światło światło;

        public PolecenieWyłączŚwiatło(Światło światło)
        {
            this.światło = światło;
        }

        public void wycofaj()
        {
            światło.włącz();
        }

        public void wykonaj()
        {
            światło.wyłącz();
        }
    }

    public class WieżaStereo
    {
        string Text;
        public WieżaStereo(string Text)
        {
            this.Text = Text;
        }

        public void włącz()
        {
            Console.WriteLine("Włącz  wieże");
        }
        public void wyłącz()
        {
            Console.WriteLine("Wyłącz  wieże");
        }
        public void ustawCD()
        {
            Console.WriteLine("ustaw CD  wieże");
        }
        public void ustawDVD()
        {
            Console.WriteLine("ustaw DVD  wieże");
        }
        public void ustawRadio()
        {
            Console.WriteLine("ustaw Radio  wieże");
        }
        public void ustawGłośność(int głośność)
        {
            Console.WriteLine("ustaw Głóśność" + głośność + "w  wieży "+Text);
        }

    }
}




public class PolecenieWieżaStereoWłączCD : Polecenie
{
    WieżaStereo wieżaStereo;

    public PolecenieWieżaStereoWłączCD(WieżaStereo wieżaStereo)
    {
        this.wieżaStereo = wieżaStereo;
    }

    public void wycofaj()
    {
        throw new NotImplementedException();
    }

    public void wykonaj()
    {
        wieżaStereo.włącz();
        wieżaStereo.ustawCD();
        wieżaStereo.ustawGłośność(11);
    }
}


public class PolecenieWieżaStereoWyłączCD : Polecenie
{
    WieżaStereo wieżaStereo;

    public PolecenieWieżaStereoWyłączCD(WieżaStereo wieżaStereo)
    {
        this.wieżaStereo = wieżaStereo;
    }

    public void wycofaj()
    {
        throw new NotImplementedException();
    }

    public void wykonaj()
    {
        wieżaStereo.wyłącz();
       
    }
}


public class SuperPilot
{

    public Polecenie[] poleceniaWłącz;
    public Polecenie[] poleceniaWyłącz;
    public Polecenie polecenieWycofaj;


    public SuperPilot()
    {
        poleceniaWłącz = new Polecenie[7];
        poleceniaWyłącz = new Polecenie[7];
        Polecenie brakPolecenia = new BrakPolecenia();
        for (int i = 0; i < 7; i++)
        {
            poleceniaWłącz[i] = brakPolecenia;
            poleceniaWyłącz[i] = brakPolecenia;
        }
        polecenieWycofaj = brakPolecenia;
    }






    public void ustawPolecenie(int slot, Polecenie włącz, Polecenie wyłącz)
    {
        poleceniaWłącz[slot] = włącz;
        poleceniaWyłącz[slot] = wyłącz;
    }

    public void wciśniętoPrzyciskWłącz(int slot)
    {
        poleceniaWłącz[slot].wykonaj();
        polecenieWycofaj = poleceniaWłącz[slot];
    }

    public void wciśniętoPrzyciskWyłącz(int slot)
    {
        poleceniaWyłącz[slot].wykonaj();
        polecenieWycofaj = poleceniaWyłącz[slot];
    }

    public void wciśniętoPrzyciskWycofaj()
    {
        polecenieWycofaj.wycofaj();
    }

    public override string ToString()
    {
        string Text = "....SuperPilot....";
        for (int i = 0; i < poleceniaWłącz.Count(); i++)
        {
            Text += "Slot " + i + " " + poleceniaWłącz[i].GetType().FullName + " ,,,,,,, " + poleceniaWyłącz[i].GetType().FullName+"\n" ;
            
           
        }
        return Text;
    }


}





