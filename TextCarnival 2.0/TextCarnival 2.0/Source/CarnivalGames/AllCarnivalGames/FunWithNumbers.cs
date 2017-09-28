using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class FunWithNumbers : CarnivalGame
    {
        public FunWithNumbers() : base()
        {

        }

        public override string getName()
        {
            return "Fun With Numbers";
        }

        public override void play()
        {
            writeOut("I'm so glad you came to visit");
        }
    }

}
