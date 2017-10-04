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
            writeOut("Humans are outnumbered by the androids existence 10 to 1");
            wait(2);
            writeOut(name + ", you are part of the 10%");
            wait(2);
            writeOut("Humans do what they can to survive in this world");
            wait(2);
            writeOut("You work in a small human bar.");
            wait(2);
            writeOut("You're required by law to also have oil products for any robots");
            wait(2);
            writeOut("It's friday night. Your shift has just ended, but your boss tells you he needs some extra hands tonight, and will pay you overtime");
            wait(2);
            writeOut("Do you [work] or [leave]");
            String opt1 = getOption("work", "leave");

            if (opt1 == "work")
            {
                writeOut("You decided to work longer");
                wait(2);
                int money = 200;
                writeOut("A new face, Roger, walks in and asks for some beer");
                wait(2);
                writeOut("Turns out he's new in the area. He doesn't particularly like drinking, but it's a good way to meet some fellow humans.");
                wait(2);
                writeOut("He's a tall and muscular man");
                wait(2);
                writeOut("He says he works in construction, slaving away for the benefit of the androids with nothing in return.");
                wait(2);
                writeOut("Not that any human has the benefit of making some decent money, but you are thankful to, for the most part, have a comfortable and calm job.");
                wait(2);
                writeOut("On his way out he hands you a card with a number on it. \"The new leaders of Ruckersburg\" it says.");
                wait(2);
                writeOut("You've heard of this group, they are a rebellion group trying to \"restore humans to there former glory\");
                wait(2);
                writeOut("You are not particularly convinced by any rebellion groups, but you take the card, serve a few more people, and before you know it the shift is over.");
                wait(2);
                writeOut("You got $200 for the night");
                wait(2);
                writeOut("While at home, the card is taunting you, asking you to call the number");
                wait(2);
                writeOut("Do you [call] or [ignore]");
                wait(2);
                writeOut("This is where your personality meter is introduced, the more rebellious options you choose the lower your score goes");
                wait(2);
                writeOut("The less rebellious options you choose the higher your score goes.");
                wait(2);
                writeOut("some choices can only be accessed with a high or low score");
                wait(2);
                String opt2 = getOption("call", "ignore");
                   if(opt2 == "call")
                    {
                    int meter = -3;
                    writeOut("Your personality score is now" + meter);
                    }
                   if(opt2 == "ignore")
                    {
                    int meter = 3;
                    writeOut("Your personality score is now" + meter);
                }
            }
            if (opt1 == "leave")
            {
                writeOut("You decided to leave");
                int money = 150;
                writeOut("You got $150 for the night");
            }





        }
    }
}
