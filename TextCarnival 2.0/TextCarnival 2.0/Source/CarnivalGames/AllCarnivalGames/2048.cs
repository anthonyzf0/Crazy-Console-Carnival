using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames {
    class _2048 : CarnivalGame {
        public _2048() : base()
        {

        }

        public override string getName()
        {
            return "2048";
        }

        public override void play()
        {
            clear();

            showTitle("WELCOME TO 2048!");

            bool finished = false;
            int[,] board = new int[4, 4];

            // spawn 2 random tiles
            board = spawnTile(board, 2);

            drawBoard(board);

            while (!finished)
            {
                String dir = getKey().ToString();

                clear();

                board = shiftBoard(board, dir);

                board = spawnTile(board, 1);

                showTitle("WELCOME TO 2048!");

                drawBoard(board);
            }

        }

        private void drawBoard(int[,] arr)
        {
            String buffer;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                buffer = "";
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    buffer += "[ ";

                    if (arr[i, j] != 0)
                    {
                        buffer += arr[i, j];
                        if (arr[i, j] < 10)
                        {
                            buffer += " ";
                        }
                    }
                    else
                    {
                        buffer += "  ";
                    }

                    buffer += " ]";

                }
                writeLine(buffer);
            }
        }

        private int[,] spawnTile(int[,] board, int iterations)
        {
            Random random = new Random();
            int blanks = countBlanks(board);

            for (int k = 0; k < iterations; k++)
            {
                int position = random.Next(0, blanks);
                int count = 0;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 0)
                        {
                            if (count == position)
                            {
                                board[i, j] = 2;
                            }
                            count++;
                        }
                    }
                }
                blanks--;
            }

            return board;
        }

        private int countBlanks(int[,] board)
        {
            int count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private int[,] shiftBoard(int[,] board, String dir)
        {
            if (dir == "UpArrow")
            {
                board = shiftUp(board);
                board = combineDown(board);
                board = shiftUp(board);
            }

            if (dir == "DownArrow")
            {
                board = shiftDown(board);
                board = combineDown(board);
                board = shiftDown(board);
            }

            if (dir == "LeftArrow")
            {
                board = shiftLeft(board);
                board = combineLeft(board);
                board = shiftLeft(board);
            }

            if (dir == "RightArrow")
            {
                board = shiftRight(board);
                board = combineRight(board);
                board = shiftRight(board);
            }

            return board;
        }

        private int[,] shiftUp(int[,] board)
        {
            // move left to right (columns)
            for (int j = 0; j < board.GetLength(1); j++)
            {
                // move top to bottom (rows)
                for (int i = 0; i < board.GetLength(0) - 1; i++)
                {
                    // fill empty space using tiles below
                    if (board[i, j] == 0)
                    {
                        int k = i;
                        while (k < board.GetLength(0) - 2 && board[k + 1, j] == 0)
                        {
                            k++;
                        }
                        board[i, j] = board[k + 1, j];
                        board[k + 1, j] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] combineUp(int[,] board)
        {
            // move left to right (columns)
            for (int j = 0; j < board.GetLength(1); j++)
            {
                // move top to bottom (rows)
                for (int i = 0; i < board.GetLength(0) - 1; i++)
                {
                    // combine tiles
                    if (board[i, j] == board[i + 1, j])
                    {
                        board[i, j] *= 2;
                        board[i + 1, j] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] shiftDown(int[,] board)
        {
            // move left to right (columns)
            for (int j = 0; j < board.GetLength(1); j++)
            {
                // move bottom to top (rows)
                for (int i = board.GetLength(0) - 1; i > 0; i--)
                {
                    // fill empty space using tiles below
                    if (board[i, j] == 0)
                    {
                        int k = i;
                        while (k > 1 && board[k - 1, j] == 0)
                        {
                            k--;
                        }
                        board[i, j] = board[k - 1, j];
                        board[k - 1, j] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] combineDown(int[,] board)
        {
            // move left to right (columns)
            for (int j = 0; j < board.GetLength(1); j++)
            {
                // move bottom to top (rows)
                for (int i = board.GetLength(0) - 1; i > 0; i--)
                {
                    // combine tiles
                    if (board[i, j] == board[i - 1, j])
                    {
                        board[i, j] *= 2;
                        board[i - 1, j] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] shiftLeft(int[,] board)
        {
            // move top to bottom (rows)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // move left to right (columns)
                for (int j = 0; j < board.GetLength(1) - 1; j++)
                {
                    // fill empty space using tiles below
                    if (board[i, j] == 0)
                    {
                        int k = j;
                        while (k < board.GetLength(1) - 2 && board[i, k + 1] == 0)
                        {
                            k++;
                        }
                        board[i, j] = board[i, k + 1];
                        board[i, k + 1] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] combineLeft(int[,] board)
        {

            // move top to bottom (rows)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // move left to right (columns)
                for (int j = 0; j < board.GetLength(1) - 1; j++)
                {
                    // combine tiles
                    if (board[i, j] == board[i, j + 1])
                    {
                        board[i, j] *= 2;
                        board[i, j + 1] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] shiftRight(int[,] board)
        {
            // move top to bottom (rows)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // move right to left (columns)
                for (int j = board.GetLength(1) - 1; j > 0; j--)
                {
                    // fill empty space using tiles below
                    if (board[i, j] == 0)
                    {
                        int k = j;
                        while (k > 1 && board[i, k - 1] == 0)
                        {
                            k--;
                        }
                        board[i, j] = board[i, k - 1];
                        board[i, k - 1] = 0;
                    }
                }
            }
            return board;
        }

        private int[,] combineRight(int[,] board)
        {
            // move top to bottom (rows)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // move left to right (columns)
                for (int j = board.GetLength(1) - 1; j > 0; j--)
                {
                    // combine tiles
                    if (board[i, j] == board[i, j - 1])
                    {
                        board[i, j] *= 2;
                        board[i, j - 1] = 0;
                    }
                }
            }
            return board;
        }
    }
}
