using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Games.BattleShip;
using Games;

namespace BattleShip_UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Game game = null;

        BattleShipGame battleship;

        [TestMethod]
        public void TestMethod1()
        {
            // Here I'll test the Background functionality of the BattleShipGame unit
            // For another games also will be created other unit test classes with its
            // series of unit test methods...
            
            game = BattleShipGame.getInstance();
            if (game != battleship)
            {
                battleship = (BattleShipGame)game;
            }

            battleship.setToNull();

        }
    }
}
