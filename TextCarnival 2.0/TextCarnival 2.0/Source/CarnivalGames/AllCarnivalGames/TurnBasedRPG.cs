using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TurnBasedRPG : CarnivalGame
    {
        public TurnBasedRPG() : base()
        {

        }

        public override string getName()
        {
            return "Turn Based RPG";
        }

        public override void play()
        {
            // do work here
            writeOut("CHOOSE A CLASS! ");
            String choice = getOption("fire", "Run away", "ORC");
            List<String> abilities;














        }
    }
}
