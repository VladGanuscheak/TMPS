using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BattleShip
{
    enum direction { UP, DOWN, LEFT, RIGHT };

    interface IShip
    {
        Ship Clone();
    }
    
    abstract class Ship : IShip
    {
        public Ship Clone()
        {
            return this;
            throw new NotImplementedException();
        }
    }

    class Carrier : Ship
    {
        private coord pos;
        private int dir;
    }

    class Warship : Ship
    {
        private coord pos;
        private int dir;
    }

    class Cruiser : Ship
    {
        private coord pos;
        private int dir;
    }

    class Submarine : Ship
    {
        private coord pos;
        private int dir;
    }

    class Destroyer : Ship
    {
        private coord pos;
        private int dir;
    }

    class coord
    {
        int x;
        int y;
    }
}
