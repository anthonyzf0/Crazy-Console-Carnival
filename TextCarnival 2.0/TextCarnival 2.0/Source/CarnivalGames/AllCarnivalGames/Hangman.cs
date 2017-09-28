using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Hangman : CarnivalGame
    {
        int tries = 5;
        String word;
        String word1 = "";
        String letters = "";

        public Hangman() : base()
        {

        }

        public override string getName()
        {
            return "Hangman";
        }

        public override void play()
        {
            showTitle("Welcome to Hangman!!!!!!");

            writeOut("I'm just going to assume you already know what hangman is and how to play...(you need at least a second person)...");

            writeOut("Have one person choose a word for you to guess: ");
            word = getInput();

            clear();
            foreach (char c in word)
            {
                word1 += "-";
            }
        }

        public void update()
        {
            writeLine("Tries: " + tries);
            writeLine("\n" + word1 + "\n\n" + letters);
            writeLine("[guess phrase] or [guess letter]");
            String input = getOption("guess phrase", "guess letter");
            if (input == "guess letter")
            {
                write("\nEnter a letter (that hasn't been used): ");
                input = getInput();
                if (word.Contains(input) && !letters.Contains(input))
                {
                    word1.
                }
            }
            else
            {
                write("\nGuess the phrase: ");
                input = getInput();
            }
        }
    }
}
