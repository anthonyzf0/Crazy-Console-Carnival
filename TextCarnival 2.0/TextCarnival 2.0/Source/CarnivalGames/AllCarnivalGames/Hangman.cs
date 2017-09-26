using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Hangman : CarnivalGame
    {
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
            String word = getInput();

            clear();
            write("-----\nl    l\nl\nl\nl\nl\n-----------");
        }
    }
}
