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


            String userResponse = "";

            showTitle("WELCOME TO SMARTBOT");

            writeOut("Hello, my name is SmartBot. What is yours?");
            write("|a0> ");
            String name = getInput();
            writeLine("");

            writeOut("Hello " + name + ", are you enjoying this?\n[Yes] or [No]");
            write("|a0> ");
            bool response = getYesNo();
            writeLine("");

            if (response)
            {
                writeOut("That's great " + name);
                write("|a0> ");
                userResponse = getInput();
                writeLine("");
            }

            while (true)
            {
                

                List<String> Jokes = new List<string>() { "Why couldn't the blond add 10 and 7 on a calculator?\n\nBecause she couldn't find the 10 key",
                            "What did one penny say to another penny?\n\nLet's get together and make cents!",
                            "What do you call someone with a mental deficiency?\n\nRetarded!"};

                if (userResponse == "thank you")
                {
                    writeOut("You're welcome!");
                    write("|a0> ");
                    userResponse = getInput();
                    writeLine("");
                }

                if (userResponse == "be a comedian")
                {
                    clear();

                    int jokes = 3;

                    writeOut("Hello, " + name + " and welcome to 'Comedian Mode' where all your dreams come true. You will get a list of 10 random jokes, once the 10 jokes have been told, you will reenter 'Normal Mode'.");
                    write("|a0> ");
                    userResponse = getInput();
                    writeLine("");

                    while (jokes > 0)
                    {
                        jokes--;

                        


                        writeOut(Jokes[0]);
                        write("|a0> ");
                        userResponse = getInput();
                        writeLine("");


                        Jokes.RemoveAt(0);

                        
                    }


                }

                else
                {
                    writeOut(SBtext[rand.Next(0, 3)]);
                    write("|a0> ");
                    userResponse = getInput();
                    writeLine("");
                }
            }











            
            


        }
    }
}
        