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

            Random rng = new Random();

            int num1 = rng.Next(1, 100);
            int num2 = rng.Next(1, 100);
            int oper = rng.Next(0, 4);
            int un = rng.Next(0, 11);
            int openLine = rng.Next(0, 10);
            int correctLine = rng.Next(0, 5);
            int wrongLine = rng.Next(0, 5);
            bool ans = true;

            if (openLine == 0) { writeOut("haha welcome to the game hope you like numbers idiot"); }
            if (openLine == 1) { writeOut("The FitnessGram Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues. The 20 meter pacer test will begin in 30 seconds. Line up at the start. The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line and run as long possible. The second time you fail to complete a lap before the sound. Your test will begin on the word start. On your mark, get ready, start"); }
            if (openLine == 2) { writeOut("haha ok i dont think you know what youre getting yourself into but lets do it"); }
            if (openLine == 3) { writeOut("no matter how you do on these you'll still probably be better than beckett because he has no idea how numbers work"); }
            if (openLine == 4) { writeOut("how we doin its ya boi, computer commin at ya with some simple math"); }
            if (openLine == 5) { writeOut("i hope you appreciate how every single thing about this game is random"); }
            if (openLine == 6) { writeOut("MY CAPS LOCK IS STUCK PLEASE HELP haha just kidding i tricked you"); }
            if (openLine == 7) { writeOut("WUBBA LUBBA DUB D- *gets cancer*"); }
            if (openLine == 8) { writeOut("i am the physical manifestation of depression"); }
            if (openLine == 9) { writeOut("this game was made by chris pettinari, not that you care, though"); }
            String unit = "";

            if (un == 0) {unit = " poop(s)";}
            if (un == 1) {unit = " Matt Smickle(s)";}
            if (un == 2) {unit = " buncc(s)";}
            if (un == 3) {unit = " snek(s)";}
            if (un == 4) {unit = " monkey(s)";}
            if (un == 5) {unit = " minkey(s)";}
            if (un == 6) {unit = " shamwow(s)";}
            if (un == 7) {unit = " quncc(s)";}
            if (un == 8) {unit = " S U C C";}
            if (un == 9) {unit = " butt(s)";}
            if (un == 10){unit = " tuncc(s)";}

            int solution = 69;

            int input;
            


            if (oper == 1)
            {
                solution = num1 - num2;

                writeOut(num1 + unit + " - " + num2 + unit + "?  (Only write the number)");

                input = Convert.ToInt32(getInput());

                if (input != solution)
                {
                    ans = false;
                }

            }

            if (oper == 0)
            {
                solution = num1 + num2;

                writeOut(num1 + unit + " + " + num2 + unit + "?  (Only write the number)");

                input = Convert.ToInt32(getInput());

                if (input != solution)
                {
                    ans = false;
                }

            }

            if (oper == 2)
            {
                if (num1 > 12)
                    num1 = rng.Next(0, 13);

                if (num2 > 12)
                    num2 = rng.Next(0, 13);

                solution = num1 * num2;

                writeOut(num1 + unit + " * " + num2 + unit + "?  (Only write the number)");

                input = Convert.ToInt32(getInput());

                if (input != solution)
                {
                    ans = false;
                }

            }

            if (oper == 3)
            {
                while (num1 % num2 != 0)
                {
                    num1 = rng.Next(1, 100);
                    num2 = rng.Next(1, 100);
                }

                solution = num1 / num2;

                writeOut(num1 + unit + " / " + num2 + unit + "?  (Only write the number)");

                input = Convert.ToInt32(getInput());

                if (input != solution)
                {
                    ans = false;
                }

            }

            if (ans)
            {
                if (correctLine == 0) { writeOut("haha nice job you got it right"); }
                if (correctLine == 1) { writeOut("the battle is won, but the war rages on"); }
                if (correctLine == 2) { writeOut("MISHUN COMPREE"); }
                if (correctLine == 3) { writeOut("HAHAHAHAHHAHAHAHAHAHAHAHAHAHAHHAH nice"); }
                if (correctLine == 4) { writeOut("if you are reading this, nice job, you got the question right"); }
                if (correctLine == 5) { writeOut("you did the math right but don't watch an anime called boku"); }
            }
            else
            {
                if (wrongLine == 0) { writeOut("you are poop"); }
                if (wrongLine == 1) { writeOut("git gud lmao"); }
                if (wrongLine == 2) { writeOut("looks like someone needs a calculator"); }
                if (wrongLine == 3) { writeOut("no what are you dumb"); }
                if (wrongLine == 4) { writeOut("B O I"); }
                if (wrongLine == 5) { writeOut("hahahhahahhAHAhAhAhAhAHAHAHAHAHAHAHAH no you got it wrong"); }
                writeOut("The answer was " + solution);
            }

        }
        }
    }