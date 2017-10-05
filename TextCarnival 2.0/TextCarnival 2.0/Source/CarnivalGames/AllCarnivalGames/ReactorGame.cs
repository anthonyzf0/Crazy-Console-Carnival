using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class ReactorGame : CarnivalGame
    {
        public ReactorGame() : base()
        {

        }

        public override string getName()
        {
            return "Reaction Game";
        }

        public override void play()
        {
            showTitle("WELCOME TO THE BEST REACTION GAME EVER");
            writeLine("A random letter will appear and you will have to type it as fast as you can.");
          

            writeLine("Ready?");
            bool ready = getYesNo();

            

            String abc = "abcdefghijklmnopqrstuvwxyz";
            int correct = 0;
            int wrong = 0;
                
            if(!ready)    
            {
                writeLine("Aww to bad. You don't play the game. You lose. Good day sir. GG NO RE.");
            }
            if (ready)
            {

                while (wrong < 1)
                {
                    Random rnd = new Random();
                    int letter = rnd.Next(1, 27);
                    if (ready)
                    {
                        writeLine(abc[letter - 1] + "");
                        ConsoleKey key = getKey();
                        writeLine("");
                       
                        if (key.ToString().ToLower() == abc[letter - 1] + "")
                        {
                          correct++;
                        }
                       else
                        {
                           wrong++;
                        }
                    }
                }
                writeLine("Congrats you got " + correct + " correct!");
            }


        }
    }
}
