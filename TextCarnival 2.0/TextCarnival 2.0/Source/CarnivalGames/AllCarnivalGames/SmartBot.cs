using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class SmartBot : CarnivalGame
    {
        public override string getName()
        {
            return "SmartBot";
        }

        public override void play()
        {
            List<string> SBtext = new List<string>( new string[] { "Hmm... Tell me more.", "Interesting, please go on.", "Try saying 'Be a Comedian'"} );
            Random rand = new Random();


            String userResponse;

            showTitle("WELCOME TO SMARTBOT");

            writeOut("Hello, my name is SmartBot. What is yours?");
            write("|a0> ");
            String name = getInput();

            writeOut("Hello " + name + ", are you enjoying this?\n[Yes] or [No]");
            write("|a0> ");
            bool response = getYesNo();

            if(response)
            {
                writeOut("That's great " + name);
                write("|a0> ");
                userResponse = getInput();
            }

            for (int i = 0; i <= int.MaxValue; i++)
            {
                if (userResponse)
                {

                }



                else
                {
                    writeOut(SBtext[rand.Next(0, 3)]);
                    write("|a0> ");
                    userResponse = getInput();
                }
            }











            
            


        }
    }
}
        