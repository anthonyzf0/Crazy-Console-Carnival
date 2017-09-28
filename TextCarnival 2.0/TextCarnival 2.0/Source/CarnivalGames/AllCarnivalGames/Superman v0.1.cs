using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Superman_v0 : CarnivalGame
    {
        public override string getName()
        {
            return "Tell your Tale Game";
        }

        public override void play()
        {
            showTitle("Welcome this Choice based Adventure Game");
            writeOut("This is a text based game where your fate will be decided by you");
            writeOut("The choices you make will change what happens next in the story, and ultimately the path you go down.");
            writeOut("Are you a [boy] or a [girl]");
            String gender = getOption("boy", "girl");

            if(gender == "boy")
            {
                writeOut("hi");
                String pronoun = "he";
            }
            if(gender == "girl")
            {
                writeOut("hi");
                String pronoun = "she";
            }

            writeOut("What is your name?");
                String name = getInput();
            
            writeOut("Welcome to the game, " + name);
            wait(2);
            writeOut("You are in a world where AI is the dominant existence in the universe");
            wait(2);
            writeOut("Humans are outnumbered by AI existence 10 to 1");
            wait(2);
            writeOut(name + ", you are part of the 10%");




        }
    }
}
