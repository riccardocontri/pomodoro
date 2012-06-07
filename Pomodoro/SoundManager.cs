using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Media;

namespace Pomodoro
{
    class SoundManager
    {
        private readonly string file;
        //private SoundPlayer Player = new SoundPlayer();
        private SoundPlayer Player;

        public SoundManager(string soundFile)
        {
            file = soundFile;
            if (File.Exists(file))
            {
                Player = new SoundPlayer(file);
                //Player.SoundLocation = file;
            }
        }

        public void Start()
        {
            if (Player != null) { Player.PlayLooping(); }
        }

        public void Stop()
        {
            if (Player != null) { Player.Stop(); }
        }
    }
}
