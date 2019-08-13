using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Budowniczy
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaDirector director = new PizzaDirector(new PeperoniBuilder());
            director.MakePizza();
            Pizza pizza=   director.pizzabuilder.GetPizza();
            pizza.ShowPizza();
            Console.ReadLine();



        }
    }
}
