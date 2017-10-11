using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCarnivalV2.Source.CarnivalGames.AllCarnivalGamesClasses;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Casino : CarnivalGame
    {
        List<Card> cards;

        public Casino() : base()
        {
            cards = new List<Card>();


        }

        public void CreateDeck()
        {
            cards.Clear();

            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Card(i, "S"));
                cards.Add(new Card(i, "H"));
                cards.Add(new Card(i, "D"));
                cards.Add(new Card(i, "C"));
            }

        }

        public void ShuffleDeck()
        {
            Random rand = new Random(System.Environment.TickCount);

            for (int i = 0; i < 1000; i++)
            {
                int num = rand.Next(0, cards.Count);
                Card c = cards[num];
                cards.RemoveAt(num);
                cards.Add(c);
            }
        }

        public override string getName()
        {
            return "Casino Chloe";
        }

        public void printCards (List<Card> cards, String name, bool hideSecond)
        {
            write(name + " cards: ");
            for (int i = 0; i < cards.Count; i++)
            {
                if (i > 0)
                    write(", ");

                if (hideSecond && i == 1)
                    write("[hidden]");
                else
                    write(cards[i].Name);
                
            }
            if (!hideSecond)
                writeLine("\nTOTAL: " + ((hideSecond) ? "[HIDDEN]" : (getTotal(cards) + "")));
            else
                writeLine("");
        }

        public int getTotal(List<Card> cards)
        {
            int total = 0, othertotal = 0;

            for (int i = 0; i < cards.Count; i++)
            {
                othertotal += cards[i].Value;
                if (cards[i].Value == 1)
                    othertotal += 10;

                total += cards[i].Value;
            }
            if (othertotal > total && othertotal <= 21)
                return othertotal;

            return total;
           // if ( = 21)
        }

        
          


        public override void play()
        {
            List<Card> dealerCards = new List<Card>();
            List<Card> playerCards = new List<Card>();

            while (true)
            {
                CreateDeck();
                ShuffleDeck();
                dealerCards.Clear();
                playerCards.Clear();

                dealerCards.Add(cards[0]);
                cards.RemoveAt(0);

                playerCards.Add(cards[0]);
                cards.RemoveAt(0);

                dealerCards.Add(cards[0]);
                cards.RemoveAt(0);

                playerCards.Add(cards[0]);
                cards.RemoveAt(0);

                //writeLine("Dealer cards: " + dealerCards[0].Name + ", [hidden]");
                printCards(dealerCards, "Dealer", true);
                printCards(playerCards, "Player", false);

                //Gets a option
                writeLine(" [hit] or a [stand]?");
                String choice = getOption("hit", "stand");

                bool bust = false;

                while (choice != "stand")
                {
                    playerCards.Add(cards[0]);
                    cards.RemoveAt(0);

                    printCards(playerCards, "Player", false);

                    if (getTotal(playerCards) > 21)
                    {
                        writeLine("Bust!");
                        bust = true;
                        break;
                    }
                    else
                    {
                        writeLine("Do you [hit] or a [stand]?");
                        choice = getOption("hit", "stand");
                    }
                }

                if (getTotal(dealerCards) >= 17)
                    printCards(dealerCards, "Dealer", false);

                if (!bust)
                {
                    while (getTotal(dealerCards) < 17)
                    {
                        dealerCards.Add(cards[0]);
                        cards.RemoveAt(0);

                        printCards(dealerCards, "Dealer", false);

                        wait(1);
                    }
                }

                int dealerTotal = getTotal(dealerCards);
                int playerTotal = getTotal(playerCards);

                if (dealerTotal > 21)
                {
                    writeLine("Dealer busts!  Player wins!");
                }
                else if (bust)
                {
                    writeLine("Player busts! Dealer wins!");
                }
                else if (playerTotal > dealerTotal)
                {
                    writeLine("Player wins!");
                }
                else if (playerTotal == dealerTotal)
                {
                    writeLine("It's a draw!");
                }
                else
                {
                    writeLine("Dealer wins!");
                }

                writeLine("");
                writeLine("Do you want to play again? [yes] or [no]");
                if (!getYesNo())
                    break;
            }

            /*
            //Shows the green title text
            showTitle("WELCOME TO THE EXAMPLE GAME!");

            writeLine("This is a basic tutorial on how to use this text basted engine and make games");
            writeLine("Follow along with it both in the console and in the code to see what to do");

            //Color example
            writeLine("|70Cool that I can color things right?|f0");

            //To add color put the character ' | ' somewhere in a string
            //then follow it by two hexadecimal characters that represend color
            //|a0 would represend changing the string to foreground color 'a' and background color '0'
            //Experiment to see what characters give what color!
            //black is '0' and white is 'f'
            //this is not part of normal c#, the client side of this program actualy parses the string and changes color
            //On a normal c# project this will not work
            writeLine("|50The Code shows how to do this!|f0");
            
            //Shows a seperation 
            showSeperator(30);

            writeLine("|e0Hey, yea you, are you getting this so far?");

            //Asks for a yes or no responce and return if it was yes
            bool getsIt = getYesNo();

            if (getsIt)
                writeLine("Cool, you get it dont you!");
            else
                writeLine("You dont :( how sad, look at the code then.");

            writeLine("Try not answering yes or no to this next one, see how that goes.");
            writeLine("Are you a enjoying this so far?");

            //Gets yes / no
            bool likesIt = getYesNo();

            writeLine("You see how you can controll what the user types so that it has to be something like I requested");

            writeLine("It doesnt have to be yes or no either.");

            writeLine("Are you a [boy] or a [girl]?");      //OMG dont get triggered, its an example

            //Gets a option
            String gender = getOption("boy", "girl");       //YES! in this case there are two options, this is for learning

            writeLine("See there how I restricted it to whatever I wanted, not just yes or no?");

            wait(0.5);

            //Writes the line, character by character
            writeOut("Hey! look at this line, it is writing itself, isnt that cool!");
            writeOut("TEST!");
            writeOut("TEST!");
            writeOut("TEST!");

            writeOut("cool right!");

            getYesNo();
        
            //Clears console
            clear();

            writeOut("You can also clear the screen like i just did!");

            wait(0.5);

            writeOut("You can also have the user wait for something, or for a specific amount of time");

            //Waits x amoutn of seconds, doesnt have to be a whole number
            wait(3.1);

            writeOut("That was 3 seconds");

            wait(2);

            writeOut("And that was another 2");

            writeOut("You can even make it super dramatic if you want");

            //The number specifies how many seconds it waits
            dramaticPause(3);

            writeOut("Do you get it so far?");

            //Gets yes no
            bool stillGetsIt = getYesNo();

            //YOu can use custom colors
            showSeperator(30,"|e0","|d0");

            writeOut("Oh, by the way, whats your name");

            String name = getInput();

            writeOut("See, " + name + " this can also get raw inputs too");

            wait(1);

            writeOut("If you want you can also make the console play sounds");

            //Makes the console beep
            beep();

            writeLine("They are fairly basic, but you can specify frequency and durration if you want");

            //Using the beep command you can specify frequency and durration
            beep(700, 2);
            beep(800, 0.5f);
            beep(900, 0.4f);
            beep(600, 1);

            writeLine("Thats kinda cool, right!");
            writeLine("If you combine some of these features you can do things like this!");
            writeLine("Wana see?");
            getYesNo();

            //This prints out text to try to sound like a type writer
            typeWriter("This is very slow, but kinda cool!");

            wait(1);

            writeLine("Thats about all that this can do.");
            
            writeLine("Have fun and build an amazing game!");
            */
            // To make your own game, dont edit this, but rather create another file in this same locaiton
            // Name the class whatever you want, but make sure that you extend the main carnival game class (inheritance)
            //
            // class [your class name] : CarnivalGame
            //
            // Make sure its namespace at the top reads:
            //
            // namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
            //
            // Have fun

        }

    }

}

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGamesClasses
{

    class Card
    {
        private String suit;  // "H","D","S","C"
        public int rank;  // 1-13

        public Card (int rank, String suit)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public String Suit
        {
            get
            {
                return suit;
            }
        }

        public int Value
        {
            get
            {
                return rank > 10 ? 10 : rank;
            }
        }

        public String Name
        {           
            get
            {
                String sname = "Hearts";

                switch (suit)
                {
                    case "H": sname = "Hearts"; break;
                    case "D": sname = "Diamonds"; break;
                    case "S": sname = "Spades"; break;
                    case "C": sname = "Clubs"; break;
                }

                String srank = rank.ToString();
                switch (rank)
                {
                    case 1: srank = "Ace"; break;
                    case 11: srank = "Jack"; break;
                    case 12: srank = "Queen"; break;
                    case 13: srank = "King"; break;
                }


                return srank + " of " + sname;
            }
        }
    }
}
