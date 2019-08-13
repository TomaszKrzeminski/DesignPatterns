using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Budowniczy
{

    public interface PizzaBuilder
    {
        Pizza pizza { get; set; }
        void SetNazwa();
        void SetSos();
        void SetSer();
        void SetDodatki();
        Pizza GetPizza();
       void MakePizza();
    }


    public class PeperoniBuilder : PizzaBuilder
    {
        public Pizza pizza { get; set; }

        public void MakePizza()
        {
           pizza= new Pizza();
        }

        public PeperoniBuilder()
        {
          
        }

        public Pizza GetPizza()
        {
            return pizza;
        }

      


        public void SetDodatki()
        {
            pizza.Dodatki = "Jakieś Dodatki";
        }

        public void SetNazwa()
        {
            pizza.Nazwa = "Peperoni";
        }

        public void SetSer()
        {
            pizza.Ser = "Ser żółty";
        }

        public void SetSos()
        {
            pizza.Sos = "Sos czosnkowy";
        }
    }





    public class PizzaDirector
    {
        public PizzaBuilder pizzabuilder;

        public PizzaDirector(PizzaBuilder pizzabuilder)
        {
            this.pizzabuilder = pizzabuilder;
        }

       public void MakePizza()
        {
            pizzabuilder.MakePizza();
            pizzabuilder.SetNazwa();
            pizzabuilder.SetSer();
            pizzabuilder.SetSos();
            pizzabuilder.SetDodatki();
        }


    }

    public class Pizza
    {
        public string Nazwa;
        public string Sos;
        public string Ser;
        public string Dodatki;


        public void ShowPizza()
        {
            Console.WriteLine("Pizza " + Nazwa + " Sos " + Sos + " Ser " + Ser + " Dodadtki " + Dodatki);
        }

    }



}
