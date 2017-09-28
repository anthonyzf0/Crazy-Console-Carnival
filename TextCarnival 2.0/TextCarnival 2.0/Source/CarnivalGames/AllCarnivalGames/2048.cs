using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class _2048 : CarnivalGame
    {
        public _2048() : base()
        {
            
        }

        public override string getName()
        {
            return "2048";
        }
        
        public override void play()
        {
            showTitle("WELCOME TO 2048!");


            bool finished = false;
            int[,] board = new int[4, 4];

            // spawn 2 random tiles

            drawBoard(board);

            while(!finished)
            {
                String dir = getKey().ToString();

                clear();

                board = shiftBoard(board, dir);

                drawBoard(board);
            }

        }

        private void drawBoard(int[,] arr)
        {
            String buffer;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                buffer = "";
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    buffer += arr[i, j] + " ";
                }
                writeLine(buffer);
            }
        }

        private int[,] shiftBoard(int[,] board, String dir)
        {
            if(dir == "UpArrow")
            {
                for(int i = 0; i < 4; i++)
                {
                    board[0, i] = 1;
                }
            }
            return board;
        }
    }
}
