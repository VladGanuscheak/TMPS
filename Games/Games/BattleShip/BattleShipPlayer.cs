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

        /*coord<int> coord DoMove(Map map)
        {
            return (coord<int>)Strategy.DoMove(map);
        }*/

        public User(Behaviour abstractFactory)
        {
            mg = abstractFactory.CreateMapGenerator();
            st = abstractFactory.CreateStrategy();
        }
    }
    public abstract class Behaviour
    {
        public abstract MapGenerator CreateMapGenerator();
        public abstract Strategy CreateStrategy();
    }

    public class UndefinedBehaviour : Behaviour // For User
    {
        public override MapGenerator CreateMapGenerator()
        {
            return new RandomMapGenerator();
        }

        public override Strategy CreateStrategy()
        {
            return new NoStrategy();
        }
    }

    public class AI_Level1 : BattleShipPlayer
    {

    }
}
