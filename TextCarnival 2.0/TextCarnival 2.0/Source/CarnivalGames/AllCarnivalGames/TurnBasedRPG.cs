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
            return "Roulette";
        }

        public override void play()
        {


            // variables
            int chips = 500;
            int amount = 0;
            int betAmount = 0;
            String color;
            int number = 0;

            

            // intro
            writeOut("You start with 500 chips");

            writeOut("Would you like to bet on a color or number");
            String option = getOption("color", "number");

            if(option == "color")
            {
                writeOut("Which color red or black");
                color = getOption("red", "black");
            }

            else
            {
                writeOut("Which number would you like to bet on?");
                number = Convert.ToInt32(getInput());

                writeOut("How many chips would you like to bet?");
                betAmount = Convert.ToInt32(getInput());

                Random roller = new Random();
                int num1 = roller.Next(0, 36);

                if (number == num1)
                {
                    // do the payout
                }



            }

            
           
                
                
                
                
                // if( selection == evens && roller %2 == 0)
            


            











        }
    }
}
