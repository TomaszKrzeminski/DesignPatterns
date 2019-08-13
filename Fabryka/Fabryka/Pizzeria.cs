using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    public abstract class Pizzeria
    {
        public Pizza zamówPizza(String type)
        {
            Pizza pizza;
            pizza = utwórzPizza(type);
            pizza.przygotowanie();
            pizza.pieczenie();
            pizza.krojenie();
            pizza.pakowanie();
            return pizza;

        }

        protected abstract Pizza utwórzPizza(String type);
    }


    public class WłoskaPizzeria : Pizzeria
    {
        protected override Pizza utwórzPizza(string type)
        {
            if (type.Equals("serowa"))
            {
                return new WłoskaSerowaPizza();
            }
            else if (type.Equals("wegetariańska"))
            {
                return new WłoskaWegetariańska();
            }
            else
            {
                return null;
            }
        }
    }

    public class AmerykańskaPizzeria : Pizzeria
    {
        protected override Pizza utwórzPizza(string type)
        {
            if (type.Equals("serowa"))
            {
                return new AmerykańskaSerowaPizza();
            }
            else if (type.Equals("wegetariańska"))
            {
                return new WłoskaWegetariańska();
            }
            else
            {
                return null;
            }
        }
    }


    public abstract class Pizza
    {
        public string nazwa;
        public Ciasto ciasto;
        public Sos sos;
        public Warzywa []warzywa;
        public Ser ser;
        public Peperoni pepperoni;
        public Małże małże;

        public abstract void przygotowanie();
      


        public void pieczenie()
        {
            Console.WriteLine("Pieczenie 25 minut w temp 350 C");
        }
        public void krojenie()
        {
            Console.WriteLine("Krojenie pizzy na 8 kawałków");
        }
        public void pakowanie()
        {
            Console.WriteLine("Pieczenie 25 minut w temp 350 C");
        }
        public string pobierzNazwa()
        {
            return nazwa;
        }



    }

    public class SerowaPizza : Pizza
    {
        FabrykaSkładnikówPizzy fabrykaSkładników;
        public SerowaPizza(FabrykaSkładnikówPizzy fabrykaSkładników)
        {
            this.fabrykaSkładników = fabrykaSkładników;
        }

        public override void przygotowanie()
        {
            Console.WriteLine("Przygotowanie "+nazwa);
            ciasto = fabrykaSkładników.utwórzCiasto();
            sos = fabrykaSkładników.utwórzSos();
            ser = fabrykaSkładników.utwórzSer();
        }
    }


    public interface FabrykaSkładnikówPizzy
    {
        Ciasto utwórzCiasto();
        Sos utwórzSos();
        Ser utwórzSer();
        Warzywa[] utwórzWarzywa();
        Peperoni utwórzPeperoni();
        Małże utwórzMałże();
    }

    public class WłoskaFabrykaSkładnikówPizzy : FabrykaSkładnikówPizzy
    {
        public Ciasto utwórzCiasto()
        {
            return new CienkieChrupieCiasto();
        }

        public Małże utwórzMałże()
        {
            return new ŚwierzeMałże();
        }

        public Peperoni utwórzPeperoni()
        {
            return new PlastryPeperoni();
        }

        public Ser utwórzSer()
        {
            return new SerReggiano();
        }

        public Sos utwórzSos()
        {
            return new SosMarinara();
        }

        public Warzywa[] utwórzWarzywa()
        {
           Warzywa warzywa[]=new Warzywa[](){ new Czosnek(),new Cebula(),new Pieczarki(),new CzerwonaPapryka()};
            return warzywa;
        }
    }

}
