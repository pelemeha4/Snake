using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Game
    {
        private bool paused;
        private uint speed { get; set; }

        public Game(uint speed)
        {
            this.speed = speed;
        }

        public void Play()
        {
            while (true)
            {

            }
        }

        public void Stop()
        {
            paused = !paused;
        }

    }
}
