using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSkładnik pancakeHouseMenu = new Menu("Menu pancake house", "śniadania");

            MenuSkładnik dinerMenu = new Menu("Menu restauracji diner", "lunch");

            MenuSkładnik uJackaMenu = new Menu("Menu u jacka", "obiady");

            MenuSkładnik deseryMenu = new Menu("Menu deserów", "desery oczywiście");

            MenuSkładnik wszystkiemenu = new Menu("wszystkie menu", "połączone menu");

            wszystkiemenu.dodaj(pancakeHouseMenu);
            wszystkiemenu.dodaj(dinerMenu);
            wszystkiemenu.dodaj(uJackaMenu);

            dinerMenu.dodaj(new PozycjaMenu("Spaghetti", "Makaron spaghetti z sosem marinara i komką chelba", true, 3.89));
            dinerMenu.dodaj(deseryMenu);
            deseryMenu.dodaj(new PozycjaMenu("Szarlotka", "Szarlotka z lodami waniliowymi", true, 1.59));

            Kenlerka kelnerka = new Kenlerka(wszystkiemenu);
            kelnerka.drukujMenu();
            Console.ReadLine();


        }
    }
}
