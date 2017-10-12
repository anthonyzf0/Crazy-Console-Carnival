using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            writeOut("A random letter will appear and you will have to type it as fast as you can.");
            writeOut("YOU DON'T NEED TO HIT ENTER");

            writeOut("What difficulty do you want to play on: " +
                "\neasy (1 second timer and lowercase letters) " +
                "\nmedium (1 second timer with lowercase letters, uppercase letters, and numbers)" +
                "\nhard (1/2 second timer with lowercase letters, uppercase letters, and numbers)");
            String difficulty = getOption("easy", "medium", "hard");

            

            String abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int correct = 0;
            int wrong = 0;
            Stopwatch time = new Stopwatch();
            Random rnd = new Random();

           
            if (difficulty == "easy")
            {
                writeLine("COUNTDOWN");
                writeLine("(3)");
                wait(1);
                writeLine("(2)");
                wait(1);
                writeLine("(1)");
                wait(1);
                while (wrong < 1)
                {
                    int letter = rnd.Next(1, 27);
                    writeLine(abc[letter - 1] + "");

                    time.Reset();
                    time.Start();

                    ConsoleKey key = getKey();
                    writeLine("");

                    time.Stop();


                    
                    if (key.ToString().ToLower() == abc[letter - 1] + "" && time.ElapsedMilliseconds <= 1000)
                    {
                      correct++;
                    }
                    else
                    {
                        writeOut("You're tooooooooo slow! or you got the answer wrong I'm not in the mood to figure it out.");
                        writeOut("Congrats you got " + correct + " correct!");
                        writeOut("Ya done now!");
                        beep();
                        wrong++;
                    }


                    
                }
                
            }
            else if( difficulty == "medium")
            {
                writeLine("COUNTDOWN");
                writeLine("(3)");
                wait(1);
                writeLine("(2)");
                wait(1);
                writeLine("(1)");
                while (wrong < 1)
                {
                    
                    int letter = rnd.Next(1, 63);
                    writeLine(abc[letter - 1] + "");

                    time.Reset();
                    time.Start();

                    ConsoleKey key = getKey();
                    writeLine("");

                    time.Stop();



                    if (key.ToString().ToLower() == abc[letter - 1] + "" && time.ElapsedMilliseconds <= 1000)
                    {
                        correct++;
                    }
                    else
                    {
                        writeOut("You're tooooooooo slow! or you got the answer wrong I'm not in the mood to figure it out.");
                        writeOut("Congrats you got " + correct + " correct!");
                        writeOut("Ya done now!");
                        beep();
                        wrong++;
                    }



                }
            }
            else if( difficulty == "hard")
            {
                writeLine("COUNTDOWN");
                writeLine("(3)");
                wait(1);
                writeLine("(2)");
                wait(1);
                writeLine("(1)");
                while (wrong < 1)
                {
                    int letter = rnd.Next(1, 63);
                    writeLine(abc[letter - 1] + "");

                    time.Reset();
                    time.Start();

                    ConsoleKey key = getKey();
                    writeLine("");

                    time.Stop();



                    if (key.ToString().ToLower() == abc[letter - 1] + "" && time.ElapsedMilliseconds <= 500)
                    {
                        correct++;
                    }
                    else
                    {
                        writeOut("You're tooooooooo slow! or you got the answer wrong I'm not in the mood to figure it out.");
                        writeOut("Congrats you got " + correct + " correct!");
                        writeOut("Ya done now!");
                        beep();
                        wrong++;
                    }



                }
            }


        }
    }
}
