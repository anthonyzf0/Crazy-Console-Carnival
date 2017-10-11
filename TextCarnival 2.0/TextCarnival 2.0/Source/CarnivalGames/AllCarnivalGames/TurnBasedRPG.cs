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
            Boolean again;
            String yorn;
            int go = 1;
            String num2;



            while (go == 1)
            {
                again = true;
                Random roller = new Random();
                int num1 = roller.Next(0, 36);

                if (chips != 0)
                {


                    writeOut("You have " + chips + " chips");

                    

                    if (num1 == 1 || num1 == 3 || num1 == 5 || num1 == 7 || num1 == 9 || num1 == 12 || num1 == 14 || num1 == 16 || num1 == 18 || num1 == 19 || num1 == 21 || num1 == 23 || num1 == 25 || num1 == 27 || num1 == 30 || num1 == 32 || num1 == 34 || num1 == 36)
                        red = true;
                    else
                        red = false;

                    
                   // if (again == true)
                   // {
                        again = false;
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
                                    payout = payout + (betAmount * 2);
                                    
                                }
                                else
                                {
                                    payout = payout + 0;

                                }

                            }
                            else
                            {
                                if (red == false)
                                {
                                    payout = payout +(betAmount * 2);
                                    
                                }
                                else
                                {
                                    payout = payout + 0;

                                }

                            }



                        }

                        else // numbers option---------------------------------------------------------------------------------------------
                        {
                            writeOut("Would you like to bet on odds, evens, or a number? ");
                            numOption = getOption("evens", "odds", "a number", "number");




                            if (numOption == "a number" || numOption == "number") // a number
                            {
                                writeOut("What number do you want to bet on? ");
                                number = Convert.ToInt32(getInput());
                                writeOut("How many chips would you like to bet?");
                                betAmount = Convert.ToInt32(getInput());

                                chips = chips - betAmount;
                            
                                if (number == num1)
                                {
                                    payout = payout + (betAmount * 35);
                                    

                                }
                                else
                                {
                                    payout = payout + 0;

                                }


                            }

                            else if (numOption == "evens") // evens
                            {
                                writeOut("How many chips would you like to bet?");
                                betAmount = Convert.ToInt32(getInput());
                                chips = chips - betAmount;

                                if (num1 % 2 == 0)
                                {
                                    payout = payout + (betAmount * 2);
                                    
                                }
                                else
                                {
                                    payout = payout +0;
                                    
                                }

                            }
                            else // odds
                            {
                                writeOut("How many chips would you like to bet?");
                                betAmount = Convert.ToInt32(getInput());
                                chips = chips - betAmount;

                                if (num1 % 2 != 0)
                                {
                                    payout = payout + (betAmount * 2);
                                    
                                }
                                else
                                {
                                    payout = payout + 0;
                                    
                                }



                            }
                        }



                    /*/
                                            writeOut("Do you want to bet on anything else? ");
                                            yorn = getOption("yes", "no");

                                            if (yorn == "yes")
                                                again = true;
                                            else again = false;/*/
                    //}
                    
                    // ending
                    chips = chips + payout;
                    if (num1 == 0)                    
                        writeOut("It was a 0, green");                    
                    else if (red == true)
                        writeOut("It was " + num1 + ", red");
                    else
                        writeOut("It was " + num1 + ", black");


                    writeOut("You won " + payout + " chips \n  ");




                    //
                }
                else
                {
                    writeOut("Sorry, you ran out of chips. You have to start over. :(");
                }
            }

        }
    }
}
