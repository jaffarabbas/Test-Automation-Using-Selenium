using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame;
namespace BowllingTest
{
    public class GameInitialization
    {
        public Game game;
        public int frame;
        public GameInitialization()
        {
            game = new Game();
            frame = 10;
        }
        public void TearDown()
        {
            game = null;
            frame = 0;
        }
        ~GameInitialization()
        {
            game = null;
            frame = 0;
        }
        public void RollStrike()
        {
            game.Roll(10);
        }

        public void FrameHits(int pin, int count)
        {
            for(int i=0; i< count; i++)
            {
                game.Roll(pin);
            }
        }

        public void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }
    }
}
