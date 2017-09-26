using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class SmartBot : CarnivalGame
    {
        public override string getName()
        {
            return "SmartBot";
        }

        public override void play()
        {
            showTitle("WELCOME TO SMARTBOT");

            writeOut("Hello, my name is SmartBot. What is yours?");
            write("|a0> ");
            String name = Console.ReadLine();

            writeOut("Hello " + name + ", are you ejoying this?\n[Yes] or [No]");
            String response = Console.ReadLine();

            response = response.ToLower();

            if(response != "yes" || response != "no")
            {
                writeOut("");
            }


        }
    }
}
        