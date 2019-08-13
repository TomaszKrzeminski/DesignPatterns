using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe
{

    public interface LatanieInterfejs
    {
        void leć();
    }



    public class LotzNapędemRakietowym : LatanieInterfejs
    {
        public void leć()
        {
            Console.WriteLine("Uuuuua lot z napędem rakietowym");
        }
    }

    public class LatamBoMamSkrzydła : LatanieInterfejs
    {
        public void leć()
        {
            Console.WriteLine("O rany latam");
        }
    }


    public class NieLatam:LatanieInterfejs
    {
        public void leć()
        {
            Console.WriteLine("Nie umiem latać");
        }
    }



    public interface KwakanieInterfejs
    {
         void kwacz();
    }

    public class Kwacz:KwakanieInterfejs
    {
        public void kwacz()
        {
            Console.WriteLine("kwa kwa");
        }
    }


    public class NieKwacz : KwakanieInterfejs
    {
        public void kwacz()
        {
            Console.WriteLine("<<Cisza>>");
        }
    }



    public class Piszcz : KwakanieInterfejs
    {
        public void kwacz()
        {
            Console.WriteLine("Piszczę");
        }
    }


    public abstract class Kaczka
    {

      public  LatanieInterfejs latanieInterfejs;
      public  KwakanieInterfejs kwakanieInterfejs;
        public void ustawLatanieInterfejs(LatanieInterfejs li)
        {
            latanieInterfejs = li;
        }
        public void ustawKwakanieInterfejs(KwakanieInterfejs ki)
        {
            kwakanieInterfejs = ki;
        }

        public Kaczka()
        {


        }
        public abstract void wyświetl();

        public void wykonajLeć()
        {
            latanieInterfejs.leć();
        }

        public void wykonajKwacz()
        {
            kwakanieInterfejs.kwacz();
        }

        public void pływaj()
        {
            Console.WriteLine("Wszystkie kaczki pływają nawet te sztuczne");
        }
    }



    public class DzikaKaczka : Kaczka
    {

        public DzikaKaczka()
        {
            kwakanieInterfejs = new Kwacz();
            latanieInterfejs = new LatamBoMamSkrzydła();
        }


        public override void wyświetl()
        {
            Console.WriteLine("Jestem prawdziwą kaczką");
        }
    }


    public class ModelKaczki : Kaczka
    {
        public override void wyświetl()
        {
            Console.WriteLine("jestem modelem kaczki");
        }

        public ModelKaczki()
        {
            latanieInterfejs = new NieLatam();
            kwakanieInterfejs = new Kwacz();
        }
    }



}
