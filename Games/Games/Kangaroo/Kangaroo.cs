using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Kangaroo
{
    class KangarooGame : Game, IGame
    {
        private static KangarooGame instance;
        private static object syncRoot = new Object();

        private KangarooGame()
        {

        }

        public static KangarooGame getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot) // Is used in order to not to be ambiguity 
                                // during execution of different threads...
                {
                    if (instance == null)
                    {
                        instance = new KangarooGame();
                    }
                }
            }
            return instance;
        }

        public void setToNull()
        {
            instance = null;
        }

        public void Settings()
        {
            throw new NotImplementedException();
        }
    }
}
