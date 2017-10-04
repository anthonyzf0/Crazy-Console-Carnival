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
            int payout = 0;
            String numOption;
            Boolean red;

            int go = 1;



            while (go == 1)
            {


                if (chips != 0)
                {


                    writeOut("You have " + chips + " chips");

                    Random roller = new Random();
                    int num1 = roller.Next(0, 36);

                    if (num1 == 1 || num1 == 3 || num1 == 5 || num1 == 7 || num1 == 9 || num1 == 12 || num1 == 14 || num1 == 16 || num1 == 18 || num1 == 19 || num1 == 21 || num1 == 23 || num1 == 25 || num1 == 27 || num1 == 30 || num1 == 32 || num1 == 34 || num1 == 36)
                        red = true;
                    else
                        red = false;


                    writeOut("Would you like to bet on a color or numbers");
                    String option = getOption("color", "numbers");

                    if (option == "color")  // Colors Option
                    {
                        writeOut("Which color red or black");
                        color = getOption("red", "black");

                        writeOut("How many chips would you like to bet?");
                        betAmount = Convert.ToInt32(getInput());
                        chips = chips - betAmount;

                        if (color == "red")
                        {
                            if (red == true)
                            {
                                payout = betAmount * 2;
                                chips = chips + payout;
                            }
                            else
                            {
                                payout = 0;
                                chips = chips + payout;
                            }
                            writeOut("You won " + payout + " chips");
                        }
                        else
                        {
                            if (red == false)
                            {
                                payout = betAmount * 2;
                                chips = chips + payout;
                            }
                            else
                            {
                                payout = 0;
                                chips = chips + payout;
                            }
                            writeOut("You won " + payout + " chips");
                        }



                    }

                    else // numbers option---------------------------------------------------------------------------------------------
                    {
                        writeOut("Would you like to bet on odds, evens, or a number? ");
                        numOption = getOption("evens", "odds", "a number");




                        if (numOption == "a number") // a number
                        {
                            writeOut("How many chips would you like to bet?");
                            betAmount = Convert.ToInt32(getInput());
                            
                            chips = chips - betAmount;

                            if (number == num1)
                            {
                                payout = betAmount * 35;
                                chips = chips + payout;

                            }
                            else
                            {
                                payout = 0;
                                chips = chips + payout;
                            }
                            writeOut("You won " + payout + " chips");

                        }

                        else if (numOption == "evens") // evens
                        {
                            writeOut("How many chips would you like to bet?");
                            betAmount = Convert.ToInt32(getInput());
                            chips = chips - betAmount;

                            if (num1 % 2 == 0)
                            {
                                payout = betAmount * 2;
                                chips = chips + payout;
                            }
                            else
                            {
                                payout = 0;
                                chips = chips + payout;
                            }
                            writeOut("You won " + payout + " chips");
                        }
                        else // odds
                        {
                            writeOut("How many chips would you like to bet?");
                            betAmount = Convert.ToInt32(getInput());
                            chips = chips - betAmount;

                            if (num1 % 2 != 0)
                            {
                                payout = betAmount * 2;
                                chips = chips + payout;
                            }
                            else
                            {
                                payout = 0;
                                chips = chips + payout;
                            }
                            writeOut("You won " + payout + " chips");


                        }
                    }
                    writeOut("It was a "+ num1);
                }
                else
                {
                    writeOut("Sorry, you ran out of chips. You have to start over. :(");
                }
            }

        }
    }
}
