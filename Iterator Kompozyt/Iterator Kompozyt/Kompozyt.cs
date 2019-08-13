using Iterator_Kompozyt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Kompozyt
{
    public abstract class MenuSkładnik
    {

        public virtual void dodaj(MenuSkładnik menuSkładnik)
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }

        public virtual void usuń(MenuSkładnik menuSkładnik)
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }

        public virtual MenuSkładnik pobierzPotomek(int i)
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }




        public virtual string pobierzNazwa()
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }


        public virtual string pobierzOpis()
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");

        }

        public virtual double pobierzCena()
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }

        public virtual bool jestWegetariańska()
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }

        public virtual void drukuj()
        {
            throw new NotSupportedException("Funkcja nie jest obsługiwana w tej klasie");
        }

    }



    public class PozycjaMenu : MenuSkładnik
    {
       public string nazwa;
        public string opis;
        public bool wegetariańska;
        public double cena;

        public PozycjaMenu(string nazwa, string opis, bool wegetariańska, double cena)
        {
            this.nazwa = nazwa;
            this.opis = opis;
            this.wegetariańska = wegetariańska;
            this.cena = cena;
        }



        public override string pobierzNazwa()
        {
            return nazwa;
        }


        public override string pobierzOpis()
        {
            return opis;

        }

        public override double pobierzCena()
        {
            return cena;
        }

        public override bool jestWegetariańska()
        {
            return wegetariańska;
        }

        public override void drukuj()
        {
            Console.WriteLine(" " + pobierzNazwa());
            if (jestWegetariańska())
            {
                Console.WriteLine(" ( w )");
            }
            Console.WriteLine(" , " + pobierzCena());
            Console.WriteLine("     ---" + pobierzOpis());
        }


    }



    public class Menu : MenuSkładnik
    {
        public string nazwa;
        public string opis;
        List<MenuSkładnik> menuSkładniki = new List<MenuSkładnik>();

        public Menu(string nazwa, string opis)
        {
            this.nazwa = nazwa;
            this.opis = opis;

        }



        public override void dodaj(MenuSkładnik menuSkładnik)
        {
            menuSkładniki.Add(menuSkładnik);
        }

        public override void usuń(MenuSkładnik menuSkładnik)
        {
            menuSkładniki.Remove(menuSkładnik);
        }

        public override MenuSkładnik pobierzPotomek(int i)
        {
            return menuSkładniki.ElementAt(i);
        }













        public override string pobierzNazwa()
        {
            return nazwa;
        }


        public override string pobierzOpis()
        {
            return opis;

        }



        public override void drukuj()
        {
            Console.WriteLine(" " + pobierzNazwa());

            Console.WriteLine("     ---" + pobierzOpis());

            Console.WriteLine("---------------------");

            foreach (var Menu in menuSkładniki)
            {
                Menu.drukuj();
            }





        }

    }




    public interface IMenu
    {
        Iterator utwórzIterator();
    }




    public interface Iterator
    {
        bool hasNext();
        Object next();
        void Remove();
    }




    public class UJackaMenu : IMenu
    {
        Dictionary<string, PozycjaMenu> pozycjeMenu = new Dictionary<string, PozycjaMenu>();

        public UJackaMenu()
        {
            dodajElement("Kanapka wegetariańska z frytkami", "Kanapka wegetariańska z sałatą i pomidorem", true, 3.99);
            dodajElement("Zupa dnia", "Filiżanka zupy dnia,sałatka", false, 3.69);
            dodajElement("Burito", "Duże burito z łaciatą fasolą sosem salsa i guacamole", true, 4.29);
        }


        public void dodajElement(string nazwa, string opis, bool wegetariańska, double cena)
        {
            PozycjaMenu pozycjaMenu = new PozycjaMenu(nazwa, opis, wegetariańska, cena);
            pozycjeMenu.Add(pozycjaMenu.nazwa, pozycjaMenu);
        }


        public Dictionary<string, PozycjaMenu> getPozycjeMenu()
        {
            return pozycjeMenu;
        }

        public Iterator utwórzIterator()
        {
            return new UJackaMenuIterator(pozycjeMenu.Values.ToArray());

        }
    }



    public class UJackaMenuIterator : Iterator
    {
        PozycjaMenu[] elementy;
        int pozycja = 0;

        public UJackaMenuIterator(PozycjaMenu[] elementy)
        {
            this.elementy = elementy;
        }

        public bool hasNext()
        {
            if (pozycja >= elementy.Count() || elementy[pozycja] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            PozycjaMenu pozycjaMenu = elementy[pozycja];
            pozycja = pozycja + 1;
            return pozycjaMenu;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }



    //public class WymienneDinerMenuIterator : Iterator
    //{
    //    PozycjaMenu[] elementy;
    //    int pozycja;


    //    public WymienneDinerMenuIterator(PozycjaMenu[] elementy)
    //    {
    //        this.elementy = elementy;
    //        Calendar teraz = Calendar.getInstance();
    //        pozycja = teraz.DAY_OF_WEEK % 2;
    //    }


    //    public bool hasNext()
    //    {
    //        if (pozycja >= elementy.Count() || elementy[pozycja] == null)
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return true;
    //        }
    //    }

    //    public object next()
    //    {
    //        PozycjaMenu pozycjaMenu = elementy[pozycja];
    //        pozycja = pozycja + 1;
    //        return pozycjaMenu;
    //    }

    //    public void Remove()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}








    public class DinerMenuIterator : Iterator
    {
        PozycjaMenu[] elementy;
        int pozycja = 0;

        public DinerMenuIterator(PozycjaMenu[] elementy)
        {
            this.elementy = elementy;
        }

        public bool hasNext()
        {
            if (pozycja >= elementy.Count() || elementy[pozycja] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            PozycjaMenu pozycjaMenu = elementy[pozycja];
            pozycja = pozycja + 1;
            return pozycjaMenu;
        }

        public void Remove()
        {
            if (pozycja <= 0)
            {
                throw new Exception("Nie można usunąć elementu przed pierwszym wywołaniem metody next()");
            }

            if (elementy[pozycja - 1] != null)
            {

            }


        }
    }



    public class PancakeHouseMenuIterator : Iterator
    {
        List<PozycjaMenu> elementy;
        int pozycja = 0;

        public PancakeHouseMenuIterator(List<PozycjaMenu> elementy)
        {
            this.elementy = elementy;
        }

        public bool hasNext()
        {
            if (pozycja >= elementy.Count() || elementy[pozycja] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object next()
        {
            PozycjaMenu pozycjaMenu = elementy[pozycja];
            pozycja = pozycja + 1;
            return pozycjaMenu;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }


    //public class PozycjaMenu
    //{
    //    public string nazwa;
    //    public string opis;
    //    public bool wegetariańska;
    //    public double cena;

    //    public PozycjaMenu(string nazwa, string opis, bool wegetariańska, double cena)
    //    {
    //        this.nazwa = nazwa;
    //        this.opis = opis;
    //        this.wegetariańska = wegetariańska;
    //        this.cena = cena;

    //    }



    //    public string pobierzNazwa()
    //    {
    //        return nazwa;
    //    }


    //    public string pobierzOpis()
    //    {
    //        return opis;

    //    }

    //    public double pobierzCena()
    //    {
    //        return cena;
    //    }

    //    public bool jestWegetariańska()
    //    {
    //        return wegetariańska;
    //    }


    }


    public class PancakeHouseMenu : IMenu
    {
        List<PozycjaMenu> pozycjeMenu;

        public PancakeHouseMenu()
        {
            pozycjeMenu = new List<PozycjaMenu>();

            dodajElement("Śniadanie naleśnikowe K&B", "Naleśniki z jajecznicą i tostem", true, 2.99);
            dodajElement("Śniadanie naleśnikowe zwykłe", "Naleśnik z jajkiem sadzonym i kiełbasą", false, 2.99);
            dodajElement("Naleśniki z jagodami", "Naleśniki ze świerzymi jagodami", true, 3.49);
            dodajElement("Wafle nadziewane", "Wafle z jagodami lub truskawkami", true, 3.59);

        }

        public void dodajElement(string nazwa, string opis, bool wegetariańska, double cena)
        {
            PozycjaMenu pozycjamenu = new PozycjaMenu(nazwa, opis, wegetariańska, cena);
            pozycjeMenu.Add(pozycjamenu);

        }

        public List<PozycjaMenu> pobierzPozycjeMenu()
        {
            return pozycjeMenu;
        }


        public Iterator utwórzIterator()
        {
            return new PancakeHouseMenuIterator(pozycjeMenu);
        }

    }


    public class DinerMenu : IMenu
    {
        static int MAKS_LICZBA_ELEMENTÓW = 6;
        int liczbaElementów = 0;
        PozycjaMenu[] pozycjeMenu;

        public DinerMenu()
        {
            pozycjeMenu = new PozycjaMenu[MAKS_LICZBA_ELEMENTÓW];
            dodajElement("Wegetariańska kanapka BSP", "(Wegetariański boczek z sałatą i pomidorem chleb przenny pełnoziarnisty", true, 2.99);
            dodajElement("Kanapka BSP", "Boczek z sałatą i pomidorem,chleb przenny pełnoziarnisty", true, 2.99);
            dodajElement("Zupa dnia", "Zupa dnia i sałatka z pomidora", false, 3.29);
            dodajElement("Hot-dog", "Hot-dog z kiszoną kapustą,rzodkiewką,cebulą i dodatkiem sera", false, 3.05);
        }


        public void dodajElement(string nazwa, string opis, bool wegetariańska, double cena)
        {
            PozycjaMenu pozycjamenu = new PozycjaMenu(nazwa, opis, wegetariańska, cena);
            if (liczbaElementów >= MAKS_LICZBA_ELEMENTÓW)
            {
                Console.WriteLine("Niestety menu jest pełnne! Nie można dodać nowej pozycji");
            }
            else
            {
                pozycjeMenu[liczbaElementów] = pozycjamenu;
                liczbaElementów = liczbaElementów + 1;
            }

        }

        public Iterator utwórzIterator()
        {
            return new DinerMenuIterator(pozycjeMenu);
        }




    }

    public class Kenlerka
    {


        MenuSkładnik wszystkieMenu;

        public Kenlerka(MenuSkładnik wszystkieMenu)
        {
            this.wszystkieMenu = wszystkieMenu;
        }

        public void drukujMenu()
        {

            wszystkieMenu.drukuj();

        }

      



    }









