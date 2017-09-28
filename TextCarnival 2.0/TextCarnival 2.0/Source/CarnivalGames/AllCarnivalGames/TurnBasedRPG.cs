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
            // class choice
            writeOut("CHOOSE A CLASS! ");
            writeOut("Mage or Warrior");
            String choice = getOption("Mage", "Warrior");
            
            // variables
            String abName1;
            String abName2;
            int roomNum = 0;
            String option;
            int health = 100;

            // ability set up
            if ( choice == "Mage")
            {
                abName1 = "Fireball";
                abName2 = "Staff Pummle";
            }
            else
            {
                abName1 = "Slash";
                abName2 = "Sheild Bash";
            }

            // intro
            writeOut("You are a travler seeking adventure and fortune..... You wlaked through a tunnle into a cave......  You know that there is a treasure in thses parts, and you have made it to the dungeon.");



            // writeOut("Do you turn left or right");
            // option = getOption("left", "right");

            /*/
            public String LorF(String op)
            {


                if (op == "left")
                {
                    return roomNum--;
                }
                else
                {
                    return roomNum++;
                }
            }

            public int encounter(int num)
            {
                if(num == 0)
                {
                    writeLine("You are in the entrance once again ");

                }

                if(num == -1)
                {
                    writeLine("");
                }


            }
            /*/


            writeOut("You appear in the next room, and you are faced with 4 maddened goblins. They are prepared to take you out of their home by force.");
            wait(1);
            writeOut("You are now in combat");











        }
    }
}
