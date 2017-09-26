using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Superman_v0 : CarnivalGame
    {
        public override string getName()
        {
            return "Tell your Tale Game";
        }

        public override void play()
        {
            showTitle("Welcome to ___");
            writeLine("This is a text based adventure game.");
            writeLine("The choices you make will change what happens next");
        }
    }
}
