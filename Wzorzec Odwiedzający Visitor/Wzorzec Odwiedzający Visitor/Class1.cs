using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Odwiedzający_Visitor
{
   
    public interface Meal
    {
         int cost { get; set; }
         string name { get; set; }
        int Accept(Visitor visitor);
    }

    public class Pancake : Meal
    {
        public int cost { get ; set; }
        public string name { get; set ; }

        public Pancake()
        {
            cost = 5;
            name = "Naleśnik";
        }

        public int Accept(Visitor visitor)
        {
          return  visitor.GetCalories(this);
        }
    }

    public class Diner : Meal
    {
        public int cost { get; set; }
        public string name { get; set; }

        public Diner()
        {
            cost = 10;
            name = "Schabowy";
        }

        public int Accept(Visitor visitor)
        {
            return visitor.GetCalories(this);
        }
    }





    public interface Menu
    {
        List<Meal> menuList { get; set; }
        string menuName { get; set; }
    }

    public class HotelMenu : Menu
    {
        public List<Meal> menuList { get ; set ; }
        public string menuName { get ; set ; }

        public HotelMenu()
        {
            menuName = "Hotel Menu";
        }

    }




    public interface Visitor
    {
        int GetCalories(Pancake pancake);
        int GetCalories(Diner diner);
    }


    public class VisitorHoliday : Visitor
    {
        public int GetCalories(Pancake pancake)
        {
            int calories = 0;
            if(pancake.name=="Naleśnik")
            {
                if(pancake.cost==5)
                {
                    calories= 200;
                }
            }
            return calories;
        }

        public int GetCalories(Diner diner)
        {
            int calories = 0;
            if (diner.name == "Schabowy")
            {
                if (diner.cost == 10)
                {
                    calories = 400;
                }
            }
            return calories;
        }
    }

    public class VisitorHalfPortion : Visitor
    {
        public int GetCalories(Pancake pancake)
        {
            int calories = 0;
            if (pancake.name == "Naleśnik")
            {
                if (pancake.cost == 5)
                {
                    calories = 200;
                }
            }
            pancake.cost = pancake.cost / 2;
            return calories/2;
        }

        public int GetCalories(Diner diner)
        {
            int calories = 0;
            if (diner.name == "Schabowy")
            {
                if (diner.cost == 10)
                {
                    calories = 400;
                }
            }
            diner.cost = diner.cost / 2;
            return calories/2;
        }
    }

}
