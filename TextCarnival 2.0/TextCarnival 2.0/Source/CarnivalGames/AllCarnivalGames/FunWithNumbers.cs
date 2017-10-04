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
            writeOut("haha i hope you like numbers idiot, anyway solve these maffs");

            Random rng = new Random();

            int num1 = rng.Next(1, 100);
            int num2 = rng.Next(1, 100);
            int oper = rng.Next(0, 4);
            int un = rng.Next(0, 10);

            String unit = "";

            if (un == 0)
            {
                unit = " poop(s)";
            }

            if(un == 1)
            {
                unit = " Matt Smickle(s)";
            }

            if(un == 2)
            {
                unit = " buncc(s)";
            }

            if (un == 3)
            {
                unit = " snek(s)";
            }

            if (un == 4)
            {
                unit = " monkey(s)";
            }

            if (un == 5)
            {
                unit = " minkey(s)";
            }

            if (un == 6)
            {
                unit = " shamwow(s)";
            }

            if (un == 7)
            {
                unit = " quncc(s)";
            }

            if (un == 8)
            {
                unit = " time(s) ive wanted to kms";
            }

            if (un == 9)
            {
                unit = " butt(s)";
            }


            if (un == 10)
            {
                unit = " tuncc(s)";
            }

            int solution = 69;
            if (oper == 3)
            {
                while (num1 % num2 != 0)
                {
                    num1 = rng.Next(1, 100);
                    num2 = rng.Next(1, 100);
                }
                solution = num1 / num2;

                writeOut(num1 + unit + " / " + num2 + unit + "?  (Only write the number)");
            }

            if (oper == 2)
            {
                solution = num1 * num2;

                writeOut(num1 + unit + " * " + num2 + unit + "?  (Only write the number)");
            }

            if (oper == 1)
            {
                solution = num1 - num2;

                writeOut(num1 + unit + " - " + num2 + unit + "?  (Only write the number)");
            }

            if (oper == 0)
            {
                solution = num1 + num2;

                writeOut(num1 + unit + " + " + num2 + unit + "?  (Only write the number)");
            }
            int input = Convert.ToInt32(getInput());

            if (input == solution)
            {
                writeOut("nice job you got it right");
            }
            else
            {
                writeOut("you are poop");
            }
        }
    }

}
