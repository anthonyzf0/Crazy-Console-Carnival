using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class BoxGame : CarnivalGame
    {
        public override string getName()
        {
            return "Block Mania";
        }

        private string[,] board;
        private int x, y;

        private string wall = "|cc--";
        private string block = "|56!!";
        private string goal = "|aa{}";
        private string player = "|01++";

        private List<string[,]> map = new List<string[,]>()
        { new string[,]{
            { "W" , "W", "W", "W", "W"},
            { "W" , "P", " ", " ", "W"},
            { "W" , " ", "G", " ", "W"},
            { "W" , "G", " ", "G", "W"},
            { "W" , "W", "W", "W", "W"}},

          new string[,]{
            { "W" , "W", "W", "W", "W"},
            { "W" , "P", " ", "G", "W"},
            { "W" , " ", "W", "W", "W"},
            { "W" , " ", "B", "G", "W"},
            { "W" , "W", "W", "W", "W"}},

          new string[,]{
            { "W" , "W", "W", "W", "W"},
            { "W" , "P", "B", "G", "W"},
            { "W" , "W", " ", "W", "W"},
            { "W" , "G", " ", "G", "W"},
            { "W" , "W", "W", "W", "W"}},


          new string[,]{
            { "W" , "W", "W", "W", "W", "W" , "W", " ", " ", " "},
            { "W" , "P", "G", "W", "G", "G" , "W", " ", " ", " "},
            { "W" , " ", "G", "W", "B", "B" , "W", "W", "W", "W"},
            { "W" , " ", " ", "W", " ", " " , "B", "G", "G", "W"},
            { "W" , "B", "B", " ", " ", " " , "W", "W", "W", "W"},
            { "W" , " ", "W", "W", "W", "G" , "W", " ", " ", " "},
            { "W" , "W", "W", " ", "W", "W" , "W", " ", " ", " "} },

          new string[,]{
              { "W","W","W","W","W","W","W"},
              { "W","W","W","W","W","G","W"},
              { "W","P","B"," ","W"," ","W"},
              { "W"," ","B","B","W"," ","W"},
              { "W"," ","B"," ","B","B","W"},
              { "W","B","G","B"," ","G","W"},
              { "W","W","G","G","W","W","W"},
              { "W","W","W","W","W","W","W"}  },

          new string[,]{
              { "W","W","W","W","W","W","W","W","W","W"," "," "," "," "},
              { "W","W","G","B","G"," "," ","G","W","W","W"," "," "," "},
              { "W","P","W","G","B"," "," ","B","W","W","W","W"," "," "},
              { "W","B"," ","W"," "," "," "," ","B"," "," ","W"," "," "},
              { "W","G","B","G","B"," ","W"," ","W"," ","W","W"," "," "},
              { "W","G","W"," "," ","W","G"," ","B"," ","W","W"," "," "},
              { "W","W","W","W","W","W","W","W","W","W","W","W"," "," "}},
          
          new string[,]{
              {"W","W","W","W","W","W","W","W","W","W","W","W"},
              {"W","P"," "," "," "," "," ","B"," "," ","G","W"},
              {"W"," "," ","W","W","W"," ","W"," ","W","G","W"},
              {"W","B"," ","W","G","W"," ","B","B"," "," ","W"},
              {"W","G","B","B","B","B"," ","W"," ","W","W","W"},
              {"W","B"," ","W","W","W"," ","W","W","W","G","W"},
              {"W","G","B"," "," "," "," "," "," "," "," ","W"},
              {"W","W","W","W","W","W","W","W","W","W","W","W"},
          }
        };
        
        public override void play()
        {
            
            clear();
            writeLine("You can push brown blocks and use arrow keys to move");
            writeLine("Q to quit");
            writeOut("Get or cover all the green squares on the map! \n*press any key to contiue*");
            getKey();

            findPlayer();
            drawBoard();
            //Gets direction

            while (true)
            {
                String dir = getKey().ToString();

                if (dir == "Q")
                    return;
                if (dir == "RightArrow")
                    push(0, 1);
                if (dir == "LeftArrow")
                    push(0, -1);
                if (dir == "UpArrow")
                    push(-1, 0);
                if (dir == "DownArrow")
                    push(1, 0);

                if (checkWin())
                {
                    if (map.Count == 1)
                    {
                        drawBoard();
                        break;
                    }

                    map.RemoveAt(0);
                    
                }

                drawBoard();
                findPlayer();

            }

            writeOut("YOU WON!");
            writeOut("YOU WON!");
            writeOut("YOU WON!");
            writeOut("YOU WON!");
            writeOut("YOU WON!");
            wait(3);
            writeLine("|f0");

        }

        public void findPlayer()
        {
            //Find player
            for (int i = 0; i < map[0].GetLength(0); i++)
                for (int j = 0; j < map[0].GetLength(1); j++)
                    if (map[0][i, j] == "P")
                    {
                        x = i; y = j;
                    }
        }

        public bool checkWin()
        {
            for (int i = 0; i < map[0].GetLength(0); i++)
                for (int j = 0; j < map[0].GetLength(1); j++)
                    if (map[0][i, j] == "G")
                    {
                        return false;
                    }
            return true;
        }

        public void push(int dX, int dY)
        {
            if (canMove(dX, dY, x, y))
            {
                shift(dX, dY, x, y, " ");
            }
            else
            {

            }
        }

        public bool canMove(int pX, int pY, int x, int y)
        {
            if (map[0][x + pX, y + pY] == " " || map[0][x + pX, y + pY] == "G") return true;
            if (map[0][x + pX, y + pY] == "B")
                return (canMove(pX, pY, pX + x, pY + y));

            return false;
        }

        public void shift(int pX, int pY, int x, int y, string c)
        {
            string val = map[0][x, y];
            
            map[0][x, y] = c;

            if (val == " " || val == "G") return;

            shift(pX, pY, x + pX, y + pY, val);
        }

        public void drawBoard()
        {
            clear();
            writeLine("Q to quit, or move with arrows");
            for (int i = 0; i < map[0].GetLength(0); i++)
            {
                for (int times = 0; times < 2; times++)
                {
                    String t = "";
                    for (int j = 0; j < map[0].GetLength(1); j++)

                        if (map[0][i, j] == "W")        t+=(wall + wall);
                        else if (map[0][ i, j] == "B")  t+=(block + block);
                        else if (map[0][i, j] == "G")   t+=(goal + goal);
                        else if (map[0][i, j] == "P")   t+=(player + player);
                        else                            t+=("|f0    ");

                    writeLine(t);
                }
            }
        }


    }
}
