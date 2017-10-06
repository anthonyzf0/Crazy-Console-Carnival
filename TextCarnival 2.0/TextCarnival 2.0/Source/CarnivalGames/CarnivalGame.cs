using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames
{
    abstract class CarnivalGame
    {
        //reading / writing functions
        private Func<String, bool> output;
        private Func<String> read;
        private Func<ConsoleKey> readKey;

        public CarnivalGame() {

        }

        //Writes a string on a new line
        public void writeLine(String line)
        {
            write(line + "\n");
        }

        //Writes a string on the current line
        public void write(String text)
        {
            output("writ" + text + "|f0");
        }
        
        //Beeps the client
        public void beep()
        {
            output("beep 600 1");
        }

        //Beeps the client with a certain frequency and time
        public void beep(float f, float t)
        {
            output("beep "+f+" "+t);
        }
        //Setup client
        public void setup(Func<String, bool> writeData, Func<String> readData, Func<ConsoleKey> readKey)
        {
            this.output = writeData;
            this.read = readData;
            this.readKey = readKey;
        }

        //Shows this title at the begining of the game
        public void showTitle(String title)
        {
            writeLine("==================================");
            writeLine("|a0" + title + "|f0");
            writeLine("==================================");

        }

        //Shows a seperation
        public void showSeperator(int length)
        {
            showSeperator(length, "|a0", "|c0");
        }

        public void showSeperator(int length, String aColor, String bColor)
        {
            String s = "";
            for (int i = 0; i < length; i++)
                s += aColor+ "=" + bColor+ "-";
            writeLine("\n"+s+"\n");
        }

        //Does a dramatic pause
        public void dramaticPause(int count)
        {
            for (int i = 0; i < count; i++)
            {
                write(". ");
                wait(1);
            }
            writeLine("");
        }

        //Clears console
        public void clear()
        {
            output("cler");
        }

        //Writes out a string character by character
        public void writeOut(String s)
        {
            foreach (char c in s)
            {
                if (c != '|')
                {
                    write(c + "");
                    wait(0.01);
                }
            }
            writeLine("");
        }

        //Slow way to write out that tries to be typeWriter is
        public void typeWriter(String s)
        {
            foreach (char c in s)
            {
                if (c != '|' && c != ' ')
                {
                    write(c + "");
                    beep(500, 0.1f);
                    wait(0.3);
                }
                else
                {
                    write(" ");
                    wait(0.5);
                }
            }
            writeLine("");
        }

        //gets a yes or no value from the user using the getOption method
        public bool getYesNo()
        {
            return getOption("yes", "no")=="yes";
        }

        //Gets a generic input
        public String getInput()
        {
            return this.read().ToLower();
        }

        public ConsoleKey getKey()
        {
            return this.readKey();
        }

        //waits for a certain number of secconds
        public void wait(double secs)
        {
            Thread.Sleep((int)(secs * 1000));
        }

        //Asks for an option in a list
        public String getOption(params String[] options)
        {
            String answer = getInput();

            if (options.Contains(answer))
                return answer;

            writeLine("Beep...Boop..Answer not valid :(");
            writeLine("Please answer as one of these: ");
            writeLine(String.Join(" ", options));
            return getOption(options);
        }
        
        //Called to play the game, have all of the main game code in here
        //When this method ends, the game is ended
        public abstract void play();

        //Gets the name of the client for the menu
        public abstract string getName();

            
    }
}
