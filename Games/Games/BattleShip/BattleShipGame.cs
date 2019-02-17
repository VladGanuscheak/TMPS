using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games.BattleShip;

namespace Games.BattleShip
{
    class BattleShipGame : Game, IGame
    {
        private int Level;
        private BattleShipPlayer player1;
        private BattleShipPlayer player2;
        private Map map1;
        private Map map2;

        public BattleShipGame(BattleShipPlayer _first, BattleShipPlayer _second)
        {
            player1 = _first;
            player2 = _second;
        }
        public void Settings()
        {
            throw new NotImplementedException();
        }
    }
}
