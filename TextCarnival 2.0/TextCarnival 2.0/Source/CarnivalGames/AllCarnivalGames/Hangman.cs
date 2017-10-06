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
        String word = "";
        String word1 = "";
        String letters = "";
        int words;

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
            String[] parts = getInput().Split(' ');
            words = parts.Length;
            foreach (String s in parts)
            {
                word += s;
            }

            clear();
            foreach (char c in word)
            {
                word1 += "-";
            }

            while (word1 != word && tries != 0)
            {
                update();
            }
        }

        public void update()
        {
            writeLine("Tries: " + tries);
            writeLine("\n" + word1 + "  " +  "Words: " +  words + "\n\n" + letters);
            writeLine("[guess phrase] or [guess letter]");
            String input = getOption("guess phrase", "guess letter");
            if (input == "guess letter")
            {
                write("\nEnter a letter (that hasn't been used): ");
                input = getInput();
                letters += input;
                if (word.Contains(input))
                {
                    char[] h = word1.ToCharArray();
                    String temp = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i].ToString() == input && h[i] == '-')
                        {
                            h[i] = input.ToCharArray()[0];
                            temp += input;
                        }
                        else
                        {
                            temp += h[i];
                        }
                        word1 = temp;
                    }
                }
                else
                {
                    tries--;
                }
            }
            else
            {
                write("\nGuess the phrase: ");
                input = getInput();

                if (input == word)
                {
                    word1 = input;
                }
                else
                {
                    tries--;
                }
            }
            clear();
        }
    }
}
