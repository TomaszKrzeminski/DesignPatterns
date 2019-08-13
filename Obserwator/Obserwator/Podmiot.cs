using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
   public interface Podmiot
    {
       void zarejestrujObserwatora(Obserwator o);
        void usuńObserwatora(Obserwator o);
        void powiadomObserwatorów();

    }


    public interface Obserwator
    {
         void aktualizacja(float temp, float wilgotność, float ciśnienie);
    }


    public interface WyświetlElement
    {
        void wyświetl();
    }


    public class DanePogodowe : Podmiot
    {
        private List<Obserwator> obserwatorzy;
        private float temperatura;
        private float wilgotność;
        private float ciśnienie;

        public DanePogodowe()
        {
            obserwatorzy = new List<Obserwator>();
        }


        public void powiadomObserwatorów()
        {
            for (int i = 0; i < obserwatorzy.Count; i++)
            {
                Obserwator Obs = obserwatorzy[i];
                Obs.aktualizacja(temperatura, wilgotność, ciśnienie);
            }
        }

        public void usuńObserwatora(Obserwator o)
        {
            obserwatorzy.Remove(o);
        }

        public void zarejestrujObserwatora(Obserwator o)
        {
            obserwatorzy.Add(o);
        }

        public void odczytZmiana()
        {
            powiadomObserwatorów();

        }

        public void ustawOdczyt(float temperatura,float wilgotność,float ciśnienie)
        {
            this.temperatura = temperatura;
            this.wilgotność = wilgotność;
            this.ciśnienie = ciśnienie;
            odczytZmiana();

        }

    }

    public class WarunkiBieżąceWyświetl : Obserwator, WyświetlElement
    {

        private float temperatura;
        private float wilgotność;
        private Podmiot DanePogodowe;

        public WarunkiBieżąceWyświetl(Podmiot DanePogodowe)
        {
            this.DanePogodowe = DanePogodowe;
            DanePogodowe.zarejestrujObserwatora(this);
        }

        public void aktualizacja(float temp, float wilgotność, float ciśnienie)
        {
            this.temperatura = temp;
            this.wilgotność = wilgotność;
            wyświetl();
        }

        public void wyświetl()
        {
            Console.WriteLine( "Warunki bierzące"+temperatura+" stopni C oraz "+wilgotność+" % wilgotności" );
        }
    }





}
