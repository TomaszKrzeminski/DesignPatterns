using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Memento
{
    class Program
    {
        static void Main(string[] args)
        {

            SavedGames savedgames = new SavedGames();
            GameGetSave getset = new GameGetSave();

            getset.SetState("state one");
            getset.SetState("state two");

            savedgames.AddGame(getset.Save());

            getset.SetState("state three");
            savedgames.AddGame(getset.Save());

            getset.SetState("state four");
            savedgames.AddGame(getset.Save());

            getset.Restore(savedgames.GetGame(0));
            Console.WriteLine();
            getset.Restore(savedgames.GetGame(2));
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
