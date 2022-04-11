using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowllingTest
{
    [TestClass]
    public class UnitTest1
    {
        GameInitialization initalizeGame;
        public UnitTest1()
        {
            initalizeGame = new GameInitialization();
        }
        [TestMethod]
        public void BLFullGameScore()
        {
            initalizeGame.FrameHits(10, 12);
            Assert.AreEqual(300, initalizeGame.game.Score());
        }

        [TestMethod]
        public void BLScores()
        {
            initalizeGame.FrameHits(0, initalizeGame.frame);
            Assert.AreEqual(0, initalizeGame.game.Score());
        }

        [TestMethod]
        public void BLSingleScores()
        {
            initalizeGame.game.Roll(0);
            Assert.AreEqual(0, initalizeGame.game.Score());
        }

        [TestMethod]
        public void BLSpareScores()
        {
            initalizeGame.RollSpare();
            initalizeGame.game.Roll(3);
            initalizeGame.FrameHits(0, 17);
            Assert.AreEqual(16, initalizeGame.game.Score());
        }

        [TestMethod]
        public void BLStrikeScore()
        {
            initalizeGame.RollStrike();
            initalizeGame.game.Roll(3);
            initalizeGame.game.Roll(4);
            initalizeGame.FrameHits(0, 16);
            Console.WriteLine("Roll Total - {0}, Result - {1}",24,initalizeGame.game.Score());
            Assert.AreEqual(24, initalizeGame.game.Score());
        }
    }
}
