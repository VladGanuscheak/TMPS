using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Games.BattleShip
{
    public abstract class BattleShipPlayer
    {
        public BattleShipPlayer()
        {

        }

        public Map CreateMap()
        {
            return null;
        }
    }

    public class User : BattleShipPlayer
    {
        // Two abstract classes which are here in
        // order to do the functional of the Buider even more flexibile
        MapGenerator mg;
        Strategy st;

        private User(MapGenerator _mg, Strategy _st)
        {
            mg = _mg;
            st = _st;
        }

        // Example of the Builder
        // скрытие было преднамеренным, поэтому установленно new
        public new Map CreateMap()
        {
            return mg.GenerateMap();
        }
    }

    public class AI : BattleShipPlayer
    {

    }
}
