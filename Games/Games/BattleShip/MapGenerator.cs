using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BattleShip
{
    public interface IMapGenerator
    {
        void GenerateMap();
    }

    public abstract class MapGenerator
    {

    }

    public class RandomMapGenerator : MapGenerator, IMapGenerator
    {
        void IMapGenerator.GenerateMap()
        {
            throw new NotImplementedException();
        }
    }

    public class AdvancedMapGenerator : MapGenerator, IMapGenerator
    {
        public void GenerateMap()
        {
            throw new NotImplementedException();
        }
    }
}
