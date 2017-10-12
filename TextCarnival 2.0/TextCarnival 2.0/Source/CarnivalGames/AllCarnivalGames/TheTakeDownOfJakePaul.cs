using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TheTakeDownOfJakePaul : CarnivalGame

    {

        Boolean j = false;

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
                    board[i, j] = "_ ";
                    if (j == 2)
                    {
                        write(board[i, j] + "\n");
                    }
                    else
                    {
                        write(board[i, j]);
                    }
                }
            }



            while (j == false)
            {
                for (int k = 1; k <= 2; k++)
                {
                    placement(board, k);
                    clear();
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            if (j == 2)
                            {
                                write(board[i, j] + "\n");
                            }
                            else
                            {
                                write(board[i, j]);
                            }
                        }
                    }
                }
                
            }
                 

            
                
                
        }

        public void placement(String[,] board, int n)
        {
            int r, c;
            writeOut("Where will you place your letter? must be in format \"xy\"");
            String place = getInput();
            
            r = Convert.ToInt32(""+place[0]);
            c = Convert.ToInt32(""+place[1]);

            if (n == 1)
            {
                board[r, c] = "H ";  
            }

            if (n == 2)
            {
                board[r, c] = "D ";
            }

            
                if (board[0,0] == board[0, 1] && board[0,0] != "_ ")
                {
                    if (board[0,1] == board[0, 2])
                    {
                       j = true;
                    }
                }

                if (board[1, 0] == board[1, 1] && board[1, 0] != "_ ")
                {
                    if (board[1, 1] == board[1, 2])
                    {
                        j = true;
                    }
                }

                if (board[2, 0] == board[2, 1] && board[2, 0] != "_ ")
                {
                    if (board[2, 1] == board[2, 2])
                    {
                        j = true;
                    }
                }

                if (board[0, 0] == board[1, 0] && board[0, 0] != "_ ")
                {
                    if (board[1, 0] == board[2, 0])
                    {
                        j = true;
                    }
                }

                if (board[0, 1] == board[1, 1] && board[0, 1] != "_ ")
                {
                    if (board[1, 1] == board[2, 1])
                    {
                        j = true;
                    }
                }

                if (board[0, 2] == board[1, 2] && board[0, 2] != "_ ")
                {
                    if (board[1, 2] == board[2, 2])
                    {
                        j = true;
                    }
                }

                if (board[0, 0] == board[1, 1] && board[0, 0] != "_ ")
                {
                    if (board[1, 1] == board[2, 2])
                    {
                        j = true;
                    }
                }

                if (board[0, 2] == board[1, 1] && board[0, 2] != "_ ")
                {
                    if (board[1, 1] == board[2, 0])
                    {
                        j = true;
                    }
                }

                if (board[0,0] != "_ " && board[0, 1] != "_ " && board[0, 2] != "_ " && board[1, 0] != "_ " && board[1, 1] != "_ " && board[1, 2] != "_ " && board[2, 0] != "_ " && board[2, 1] != "_ " && board[2, 2] != "_ ")
                {
                    j = true;
                }

        }
    }
}
