using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TheTakeDownOfJakePaul : CarnivalGame

    {
        public TheTakeDownOfJakePaul() : base()
        {

        }

        public override string getName()
        {
            return "When The Haters Dab Back!?!?";
        }

        public override void play()
        {
            showTitle("Welcome Tic Dab Toe");

            writeOut("DAB ON THEM HATERS!!!!!");
            writeOut("Player 1 will be Haters, Player 2 will be Dab.");
            writeOut("Haters will start.");
            

            String[,] board = new String[3,3];

            

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        board[i, j] = "Dab";
                        write(board[i, j]);
                    }
                }

                
                
            
        }

        public void placement()
        {
            int r, c, n;
            writeOut("Where will you place your word? Ex. (player# row column)");
            String[] place = Console.ReadLine().Split(' ');

            n = Convert.ToInt32(place[0]);
            r = Convert.ToInt32(place[1]);
            c = Convert.ToInt32(place[2]);


        }
    }
}
