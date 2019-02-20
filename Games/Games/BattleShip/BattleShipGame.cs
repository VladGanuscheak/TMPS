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
        
        // Singleton
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
        // Parametrezid Singleton
        private BattleShipGame(BattleShipPlayer _first, BattleShipPlayer _second)
        {
            if (_first != null) player1 = _first;
            if (_second != null) player2 = _second;
        }

        // Singleton + Builder
        public static BattleShipGame getInstance(BattleShipPlayer _first, BattleShipPlayer _second)
        {
            if (instance == null)
            {
                lock (syncRoot) // Is used in order to not to be ambiguity 
                                // during execution of different threads...
                {
                    if (instance == null)
                    {
                        player1 = _first;  // player1 is of type BattleShipPlayer abstract class
                        player2 = _second; // player2 is of type BattleShipPlayer abstract class
                        instance = new BattleShipGame();
                    }
                }
            }
            return instance;
        }

        // method of the Builder which sets the sample values for the Map class variables
        void BuildMap()
        {
            if (player1 != null)
            {
                map1 = player1.CreateMap();
            }

            if (player2 != null)
            {
                map2 = player2.CreateMap();
            }
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
