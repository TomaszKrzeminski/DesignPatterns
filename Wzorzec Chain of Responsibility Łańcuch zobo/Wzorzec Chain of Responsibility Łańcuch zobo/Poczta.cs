using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Chain_of_Responsibility_Łańcuch_zobo
{

    public enum TypPoczty
    {
        Spam,Pochwała,Skarga,Zapotrzebowanie,Brak
    }


   public interface Poczta
    {
        Poczta poczta { get; set; }

        void ForwardRequest(TypPoczty typ);
        void SetObject(Poczta poczta);

    }



    public class Spam : Poczta
    {
        public Poczta poczta { get; set; }

        public void ForwardRequest(TypPoczty typ)
        {
            Console.WriteLine("Sprawdzam w Spamie");
            if(typ==TypPoczty.Spam)
            {
                Console.WriteLine("Przekazuje do działu spam pocztę typu "+typ.ToString());
            }
            else if(poczta!=null)
            {
               poczta.ForwardRequest(typ);
            }


           
        }

        public void SetObject(Poczta poczta)
        {
            this.poczta = poczta;
        }
    }

    public class Pochwała : Poczta
    {
        public Poczta poczta { get; set; }

        public void ForwardRequest(TypPoczty typ)
        {
            Console.WriteLine("Sprawdzam w Pochwała");
            if (typ == TypPoczty.Pochwała)
            {
                Console.WriteLine("Przekazuje do działu Pochwała pocztę typu " + typ.ToString());
            }
            else if (poczta != null)
            {
                poczta.ForwardRequest(typ);
            }



        }

        public void SetObject(Poczta poczta)
        {
            this.poczta = poczta;
        }
    }

    public class Skarga : Poczta
    {
        public Poczta poczta { get; set; }

        public void ForwardRequest(TypPoczty typ)
        {
            Console.WriteLine("Sprawdzam w Skarga");
            if (typ == TypPoczty.Skarga)
            {
                Console.WriteLine("Przekazuje do działu Skarga pocztę typu " + typ.ToString());
            }
            else if (poczta != null)
            {
                poczta.ForwardRequest(typ);
            }



        }

        public void SetObject(Poczta poczta)
        {
            this.poczta = poczta;
        }
    }

    public class Zapotrzebowanie : Poczta
    {
        public Poczta poczta { get; set; }

        public void ForwardRequest(TypPoczty typ)
        {
            Console.WriteLine("Sprawdzam w Zapotrzebowanie");
            if (typ == TypPoczty.Zapotrzebowanie)
            {
                Console.WriteLine("Przekazuje do działu Zapotrzebowanie pocztę typu " + typ.ToString());
            }
            else if (poczta != null)
            {
                poczta.ForwardRequest(typ);
            }



        }

        public void SetObject(Poczta poczta)
        {
            this.poczta = poczta;
        }
    }





}
