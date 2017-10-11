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
            List<string> SBtext = new List<string>(new string[]
            { "Hmm... Tell me more.",
                "Interesting, please go on.",
                "Try saying 'Be a Comedian'",
                "To end the conversation at anytime, say 'goodbye'"});


            Random rand = new Random();

            clear();
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


                List<String> Jokes = new List<string>()
                { "Why couldn't the blond add 10 and 7 on a calculator?\n\nBecause she couldn't find the 10 key",
                  "What did one penny say to another penny?\n\nLet's get together and make cents!",
                  "what's the ugliest thing in the world?\n\nlook in a mirror and you'll find out.",
                  "What do you call someone with a mental deficiency?\n\nRetarded!",
                  "So there's this guy, and he goes to a Comic-Con convention, and he notices this very robust man in a wheelchair... \nand he says to him\n\nWhat are you supposed to be? 'Professor X'-tra large!",
                  "Hey what's that under your chin?\n\nOh! It's your other chin!",
                  "What do you call 2 Mexicans playing basketball?\n\nJuan on Juan!",
                  "What do you call a flying Jew?\n\nSmoke.",
                  "If virgin sacrifices were still around...\n\nSci-Fi conventions would look like Auschwitz!",
                  "I don't know about you, but im pretty sure Puerto Rico is the Windy City... not Chicago\n\nHurricane jokes are messed up but funny... and yes I know Puerto Rico is not a city."};

                if (userResponse == "thank you")
                {
                    writeOut("You're welcome!");
                    write("|a0> ");
                    userResponse = getInput();
                    writeLine("");
                }

                if (userResponse == "goodbye")
                {
                    writeOut("It was nice chatting with you " + name + " I hope to hear from you again.");
                    wait(3);
                    writeOut("EXITING GAME");
                    dramaticPause(3);
                    clear();
                    break;
                }

                if (userResponse == "be a comedian")
                {
                    clear();

                    int jokes = Jokes.Count;

                    writeOut("Hello, " + name + " and welcome to 'Comedian Mode' where all your dreams come true. You will get a list of 10 random jokes,\n once the 10 jokes have been told, you will reenter 'Normal Mode'.");
                    write("|a0> ");
                    userResponse = getInput();
                    writeLine("");

                    while (jokes > 0)
                    {
                        if (userResponse == "goodbye")
                        {
                            break;
                        }
                        jokes--;


                        writeOut(Jokes[index: 0]);
                        write("|a0> ");
                        userResponse = getInput();
                        writeLine("");


                        Jokes.RemoveAt(0);


                    }

                    if (jokes == 0)
                    {
                        clear();
                        writeOut("Reentering Normal Mode");
                        dramaticPause(3);
                        clear();
                        writeOut("Welcome back to Normal Mode " + name + " I hope you enjoyed the Comedian Mode experience.");
                        write("|a0> ");
                        userResponse = getInput();
                        writeLine("");
                    }

                }

                else
                {
                    writeOut(SBtext[rand.Next(0, SBtext.Count)]);
                    write("|a0> ");
                    userResponse = getInput();
                    writeLine("");
                }
            }
        }
    }
}