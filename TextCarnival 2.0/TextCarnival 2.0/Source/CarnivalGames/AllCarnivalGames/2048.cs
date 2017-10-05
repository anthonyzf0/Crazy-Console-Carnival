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
            bool finished = false, boardUpdated = false;
            int[,] board = new int[4, 4], oldBoard;

            clear();

            showTitle("WELCOME TO 2048!");
            writeLine("USE THE ARROW KEYS TO PLAY. \nCOMBINE TILES TO MAKE 2048\nPRESS Q TO QUIT\n");

            // spawn 2 random tiles
            board = spawnTile(board, 2);

            drawBoard(board);

            while (!finished)
            {
                String dir = getKey().ToString();

                if (dir == "Q")
                {
                    break;
                }

                clear();

                oldBoard = board.Clone() as int[,];

                board = shiftBoard(board, dir);

                boardUpdated = boardChanged(oldBoard, board);

                if (boardUpdated)
                {
                    board = spawnTile(board, 1);
                }

                showTitle("WELCOME TO 2048!");
                writeLine("USE THE ARROW KEYS TO PLAY. \nCOMBINE TILES TO MAKE 2048\nPRESS Q TO QUIT\n");

                drawBoard(board);

                if (!boardUpdated)
                {
                    writeLine("INVALID MOVE");
                }

                finished = !hasRemainingMoves(board) || gameWon(board);
            }

            if (gameWon(board))
            {
                writeLine("\nCONGRATULATIONS, YOU WIN!");
            }
            else
            {
                writeLine("\nGAME OVER");
            }

        }

        private void drawBoard(int[,] arr)
        {
            String buffer;
            Dictionary<int, String> colorMap = getColorMap();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                buffer = "";
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    buffer += "[ ";

                    if (arr[i, j] != 0)
                    {
                        if (arr[i, j] < 10)
                        {
                            buffer += " ";
                        }



                        buffer += colorMap[(int)Math.Log(arr[i, j], 2)] + arr[i, j] + colorMap[0];

                        if (arr[i, j] < 100)
                        {
                            buffer += " ";
                        }
                        if (arr[i, j] < 1000)
                        {
                            buffer += " ";
                        }
                    }
                    else
                    {
                        buffer += "    ";
                    }

                    buffer += " ]";

                }
                writeLine(buffer);
            }
        }

        private int[,] spawnTile(int[,] boardIn, int iterations)
        {
            int[,] board = boardIn.Clone() as int[,];

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
                                int newTile = random.Next(0, 10) != 0 ? 2 : 4; // 10% chance of spawning a 4, else spawn a 2
                                board[i, j] = newTile;
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

        private bool boardChanged(int[,] start, int[,] end)
        {
            if (start.GetLength(0) != end.GetLength(0) || start.GetLength(1) != end.GetLength(1))
            {
                return true;
            }
            for (int i = 0; i < start.GetLength(0); i++)
            {
                for (int j = 0; j < start.GetLength(1); j++)
                {
                    if (start[i, j] != end[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private int[,] shiftBoard(int[,] boardIn, String dir)
        {
            int[,] board = boardIn.Clone() as int[,];

            if (dir == "UpArrow")
            {
                board = shiftUp(board);
                board = combineUp(board);
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

        private int[,] shiftUp(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] combineUp(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] shiftDown(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] combineDown(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] shiftLeft(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] combineLeft(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] shiftRight(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

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

        private int[,] combineRight(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,];

            // move top to bottom (rows)
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // move right to left (columns)
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

        private Dictionary<int, String> getColorMap()
        {
            return new Dictionary<int, String> {
                {0, "|f0"}, // white on black
                {1, "|f0"}, // white on black
                {2, "|a0"}, // green on black
                {3, "|b0"}, // cyan on black
                {4, "|c0"}, // red on black
                {5, "|d0"}, // purple on black
                {6, "|e0"}, // yellow on black
                {7, "|1f"}, // dark blue on white
                {8, "|2f"}, // dark green on white
                {9, "|3f"}, // dark cyan on white
                {10, "|0f"}, // black on white
                {11, "|0f"} // black on white
            };
        }

        private bool hasRemainingMoves(int[,] boardIn)
        {
            int[,] board = boardIn.Clone() as int[,], tempBoard;


            tempBoard = board.Clone() as int[,];
            tempBoard = shiftUp(tempBoard);
            tempBoard = combineUp(tempBoard);

            if (boardChanged(board, tempBoard))
            {
                return true;
            }

            tempBoard = board.Clone() as int[,];
            tempBoard = shiftDown(tempBoard);
            tempBoard = combineDown(tempBoard);

            if (boardChanged(board, tempBoard))
            {
                return true;
            }

            tempBoard = board.Clone() as int[,];
            tempBoard = shiftLeft(board);
            tempBoard = combineLeft(board);

            if (boardChanged(board, tempBoard))
            {
                return true;
            }

            tempBoard = board.Clone() as int[,];
            tempBoard = shiftRight(board);
            tempBoard = combineRight(board);

            if (boardChanged(board, tempBoard))
            {
                return true;
            }

            return false;
        }

        private bool gameWon(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 2048)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
