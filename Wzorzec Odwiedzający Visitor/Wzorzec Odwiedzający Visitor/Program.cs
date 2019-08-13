using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Odwiedzający_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new HotelMenu();
            menu.menuList = new List<Meal>();

            Meal pancake = new Pancake();
            Meal diner = new Diner();

            menu.menuList.Add(pancake);
            menu.menuList.Add(diner);

            Visitor holiday = new VisitorHoliday();
            Visitor halfportion = new VisitorHalfPortion();

            foreach (var meal in menu.menuList)
            {
              int calories =  meal.Accept(holiday);
                Console.WriteLine($"Meal cost {meal.cost}  meal nam {meal.name}  calories {calories}");
            }

            foreach (var meal in menu.menuList)
            {
                int calories = meal.Accept(halfportion);
                Console.WriteLine($"Meal cost {meal.cost}  meal nam {meal.name}  calories {calories}");
            }



            Console.ReadLine();

        }
    }
}
