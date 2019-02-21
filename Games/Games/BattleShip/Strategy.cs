using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BattleShip
{
    interface IStrategy
    {
        void DoMove();
    }

    interface ILearn
    {
        void Analize();
        void SaveStats();
    }

    public abstract class Strategy
    {

    }

    public class NoStrategy : Strategy, IStrategy, ILearn
    {
        public NoStrategy()
        {

        }

        public void Analize()
        {
            throw new NotImplementedException();
        }

        public void DoMove()
        {
            throw new NotImplementedException();
        }

        public void SaveStats()
        {
            throw new NotImplementedException();
        }
    }

    public class BeatRandomCell : Strategy, IStrategy, ILearn
    {
        public BeatRandomCell()
        {

        }

        public void Analize()
        {
            throw new NotImplementedException();
        }

        public void DoMove()
        {
            throw new NotImplementedException();
        }

        public void SaveStats()
        {
            throw new NotImplementedException();
        }
    }
}
