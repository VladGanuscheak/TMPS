using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Matches
{
    class MatchesGame : Game, IGame
    {
        private static MatchesGame instance;
        private static object syncRoot = new Object();

        private MatchesGame()
        {

        }

        public static MatchesGame getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot) // Is used in order to not to be ambiguity 
                                // during execution of different threads...
                {
                    if (instance == null)
                    {
                        instance = new MatchesGame();
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
