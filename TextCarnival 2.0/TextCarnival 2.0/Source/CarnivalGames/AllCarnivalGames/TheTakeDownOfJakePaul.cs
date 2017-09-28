using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TheTakeDownOfJakePaul : CarnivalGame

    {
        public TheTakeDownOfJakePaul() : base()
        {

        }

        public override string getName()
        {
            return "When The Haters Dab Back!?!?";
        }

        public override void play()
        {
            showTitle("Welcome Tic Dab Toe");

            writeOut("DAB ON THEM HATERS!!!!!");
            writeOut("X will start");


          
        }
    }
}
