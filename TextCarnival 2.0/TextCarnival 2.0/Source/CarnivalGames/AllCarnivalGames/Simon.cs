using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Simon : CarnivalGame
    {
        public override string getName()
        {
            return "Simon";
        }
        public override void play()
        {
            Random Rando = new Random();
            int rd1 = Rando.Next(1, 5);
            int rd2 = Rando.Next(1, 5);
            int rd3 = Rando.Next(1, 5);
            int rd4 = Rando.Next(1, 5);
            int rd5 = Rando.Next(1, 5);
            int counter = 0;
            int a;
            int b;
            int c;
            int d;
            int e;
            string Ans;
            string Ans2;
            string Ans3;
            string Ans4;
            string Ans5;
            bool isCorrect = true;
            string ready;
            bool start= false;

            showTitle("WELCOME TO SIMON");
            writeOut("This version of simon is based off of sounds");
            writeOut("There are 4 different sounds and you should return them in the order you hear them");
            writeOut("return the correct order 5 times and you win!");

            while(start == false)
            {
                writeOut("each sound is assigned to a number 1-4");
                writeLine("1 is"); beep(100, 1); wait(1);
                writeLine("2 is"); beep(300, 1); wait(1);
                writeLine("3 is"); beep(600, 1); wait(1);
                writeLine("4 is"); beep(900, 1); wait(1);
                writeLine("Are you ready to play? type [yes] to play, type [no] to here the sounds again");
                ready = getInput();
                if (ready == "yes")
                {
                    start = true;
                }
            }
            writeOut("ROUND 1");

                if (rd1 == 1)
                {
                    beep(100, 1);
                }
                if (rd1 == 2)
                {
                    beep(300, 1);
                }
                if (rd1 == 3)
                {
                    beep(600, 1);
                }
                if (rd1 == 4)
                {
                    beep(900, 1);
                }
                if (counter == 0)
                {
                    writeLine("Enter your answer:");
                    Ans = getInput();
                    a = Convert.ToInt32(Ans);


                    if (a == rd1)
                    {
                        writeLine("Correct!");
                        counter++;
                        writeOut("ROUND 2");
                    }
                    if (a != rd1 && counter == 0)
                    {
                        writeLine("Wrong! You Lose!");
                        isCorrect = false;
                    }
                }

                if (counter >= 1 && isCorrect == true)
                {
                    if (rd1 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd1 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd1 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd1 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd2 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd2 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd2 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd2 == 4)
                    {
                        beep(900, 1);
                    }
                    if(counter == 1)
                    {
                        writeLine("Enter your answers:");
                        Ans = getInput();
                        Ans2 = getInput();
                        a = Convert.ToInt32(Ans);
                        b = Convert.ToInt32(Ans2);

                        if (b == rd2 && a == rd1)
                        {
                            writeLine("Correct!");
                            counter++;
                            writeOut("ROUND 3");
                        }
                        if (b != rd2)
                        {
                            writeLine("Wrong! You Lose!");
                            isCorrect = false;
                        }
                    }
                   

                }
                if (counter >= 2 && isCorrect == true)
                {
                    if (rd1 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd1 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd1 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd1 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd2 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd2 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd2 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd2 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd3 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd3 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd3 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd3 == 4)
                    {
                        beep(900, 1);
                    }
                    if(counter == 2)
                    {
                        writeLine("Enter your answer:");
                        Ans = getInput();
                        Ans2 = getInput();
                        Ans3 = getInput();
                        a = Convert.ToInt32(Ans);
                        b = Convert.ToInt32(Ans2);
                        c = Convert.ToInt32(Ans3);

                        if (c == rd3 && b == rd2 && a == rd1 && counter == 2)
                        {
                            writeLine("Correct!");
                            counter++;
                        writeOut("ROUND 4");
                        }
                        if (c != rd3)
                        {
                            writeLine("Wrong! You Lose!");
                            isCorrect = false;
                        }
                    }

                }
                if (counter >= 3 && isCorrect == true)
                {
                    if (rd1 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd1 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd1 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd1 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd2 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd2 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd2 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd2 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd3 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd3 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd3 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd3 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd4 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd4 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd4 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd4 == 4)
                    {
                        beep(900, 1);
                    }
                    if(counter == 3)
                    {
                        writeLine("Enter your answers:");
                        Ans = getInput();
                        Ans2 = getInput();
                        Ans3 = getInput();
                        Ans4 = getInput();
                        a = Convert.ToInt32(Ans);
                        b = Convert.ToInt32(Ans2);
                        c = Convert.ToInt32(Ans3);
                        d = Convert.ToInt32(Ans4);

                        if (d == rd4 && c == rd3 && b == rd2 && a == rd1)
                        {
                            writeLine("Correct!");
                            counter++;
                            writeLine("Round 4");
                        }
                        if (d != rd4)
                        {
                            writeLine("Wrong! You Lose!");
                            isCorrect = false;
                        }
                    }
                }
                if (counter >= 4 && isCorrect == true)
                {
                    if (rd1 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd1 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd1 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd1 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd2 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd2 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd2 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd2 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd3 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd3 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd3 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd3 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd4 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd4 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd4 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd4 == 4)
                    {
                        beep(900, 1);
                    }
                    if (rd5 == 1)
                    {
                        beep(100, 1);
                    }
                    if (rd5 == 2)
                    {
                        beep(300, 1);
                    }
                    if (rd5 == 3)
                    {
                        beep(600, 1);
                    }
                    if (rd5 == 4)
                    {
                        beep(900, 1);
                    }
                    if(counter == 4)
                    {
                        writeLine("Enter your answer:");
                        Ans = getInput();
                        Ans2 = getInput();
                        Ans3 = getInput();
                        Ans4 = getInput();
                        Ans5 = getInput();
                        a = Convert.ToInt32(Ans);
                        b = Convert.ToInt32(Ans2);
                        c = Convert.ToInt32(Ans3);
                        d = Convert.ToInt32(Ans4);
                        e = Convert.ToInt32(Ans5);

                        if (e == rd5 && d == rd4 && c == rd3 && b == rd2 && a == rd1)
                        {
                            writeLine("Correct!");
                            counter++;
                            writeOut("YOU WIN!!");
                        }
                        if (e != rd5)
                        {
                            writeLine("Wrong! You Lose!");
                            isCorrect = false;
                        }
                    }
                }
            
        }

    }
}
    