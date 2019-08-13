using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{


    public abstract class NapójZKofeiną
    {
     public   void recepturaParzenia()
        {
            gotowanieWody();
            zaparzanie();
            nalewanieDoFiliżanki();
            domieszanieDodatków();
        }

       public abstract  void zaparzanie();
       public abstract void domieszanieDodatków();

       public  void gotowanieWody()
        {
            Console.WriteLine("Gotowanie wody");
        }

      public  void nalewanieDoFiliżanki()
        {
            Console.WriteLine("Nalewanie do filiżanki");
        }


    }









    public class Kawa : NapójZKofeiną
    {
        public override void domieszanieDodatków()
        {
            throw new NotImplementedException();
        }

        public override void zaparzanie()
        {
            throw new NotImplementedException();
        }
    }





    public class Herbata : NapójZKofeiną
    {
        public override void domieszanieDodatków()
        {
            throw new NotImplementedException();
        }

        public override void zaparzanie()
        {
            throw new NotImplementedException();
        }
    }





}
