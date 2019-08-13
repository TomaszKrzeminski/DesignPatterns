using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Memento
{
   
    public class Game
    {
        public string State;

        public Game(string State)
        {
            this.State = State;
        }

        public string GetState()
        {
            return State;
        }


    }

    public class SavedGames
    {

        List<Game> GameList = new List<Game>();

        public void AddGame(Game game)
        {
            GameList.Add(game);
        }

        public Game GetGame(int index)
        {
          return  GameList[index];
        }

    }


    public class GameGetSave
    {

        public string State;

        public void SetState(string State)
        {
            this.State = State;
        }

        public Game Save()
        {
            Console.WriteLine("Saving Game");
            return new Game(State);
        }

        public void Restore(Game game)
        {
            State = game.State;
            Console.WriteLine("State after restoring "+State);
        }

    }


}
