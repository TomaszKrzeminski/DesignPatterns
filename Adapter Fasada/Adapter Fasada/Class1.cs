using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Fasada
{
   public interface Kaczka
    {
        void kwacz();
        void lataj();
    }


    public class DzikaKaczka : Kaczka
    {
        public void kwacz()
        {
            Console.WriteLine("Kwa kwa");
        }

        public void lataj()
        {
            Console.WriteLine("Latam  Latam");
        }
    }

    public interface Indyk
    {
        void gulgocz();
        void lataj();
    }

    public class DzikiIndyk : Indyk
    {
        public void gulgocz()
        {
            Console.WriteLine("Gul gul");
        }

        public void lataj()
        {
            Console.WriteLine("O rany latam ale tylko na krótkich dystansach");
        }
    }



    public class IndykAdapter:Kaczka
    {
        Indyk indyk;

        public IndykAdapter(Indyk indyk)
        {
            this.indyk = indyk;
        }


        public void kwacz()
        {
            indyk.gulgocz();
        }

        public void lataj()
        {
            for (int i = 0; i < 5; i++)
            {
                indyk.lataj();
            }
        }


    }





}
