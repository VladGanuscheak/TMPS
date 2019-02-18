using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games.BattleShip;

namespace Games.BattleShip
{
    class BattleShipGame : Game, IGame // Singleton class
    {
        private static BattleShipGame instance;
        private static object syncRoot = new Object();

        private int Level;
        private static BattleShipPlayer player1;
        private static BattleShipPlayer player2;
        private Map map1;
        private Map map2;

        private BattleShipGame()
        {
            player1 = player2 = null;
        }

        private BattleShipGame(BattleShipPlayer _first, BattleShipPlayer _second)
        {
            if (_first != null) player1 = _first;
            if (_second != null) player2 = _second;
        }
        
        public static BattleShipGame getInstance()
        {
            if (instance == null)
            {
                lock(syncRoot) // Is used in order to not to be ambiguity 
                               // during execution of different threads...
                {
                    if (instance == null)
                    {
                        instance = new BattleShipGame();
                    }
                }
            }
            return instance;
        }

        public void setToNull()
        {
            instance = null;
        }

        public static void setPlayer1(BattleShipPlayer _first)
        {
            player1 = _first;
        }

        public static void setPlayer2(BattleShipPlayer _second)
        {
            player2 = _second;
        }

        public void Settings()
        {
            throw new NotImplementedException();
        }
    }
}
