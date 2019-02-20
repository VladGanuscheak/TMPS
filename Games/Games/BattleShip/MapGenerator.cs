using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BattleShip
{
    public interface IMapGenerator
    {
        Map GenerateMap();
    }

    public abstract class MapGenerator
    {
        internal Map GenerateMap()
        {
            return null;
        }
    }

    public class RandomMapGenerator : MapGenerator, IMapGenerator
    {
        Map IMapGenerator.GenerateMap()
        {
            return new Map();
            throw new NotImplementedException();
        }
    }

    public class AdvancedMapGenerator : MapGenerator, IMapGenerator
    {
        Map IMapGenerator.GenerateMap()
        {
            return new Map();
            throw new NotImplementedException();
        }
    }
}
