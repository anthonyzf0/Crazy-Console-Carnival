using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames;

namespace TextCarnivalV2.Source
{
    /*
     * This is the main file of this game, it contains the Main method
     */
    class Program
    {

        //To run this game in debug mode rather than as a client or a server, set this to true
        //That will allow it to run without a server connection
        public static bool runInDebug = true;

        //Game starts here, this method is run to start the game
        static void Main(string[] args)
        {
            //If you run in debug, start a local server and client
            if (runInDebug)
            {
                Server.ServerConnection.runningDebug = true;
                Server.Server.startServer();
                new Client.Client(true).start();
            }
            else
            {
                //Is this run as a client or a server?
                Console.WriteLine("Welcome to the Text Carnival!");
                Console.WriteLine("Start a [server] or a [client]");

                String choice = Console.ReadLine();

                //Determine if you should run as a server or a client, then run them
                if (choice == "server")
                {
                    Server.Server.startServer();    //Accesses the Server file and starts a server
                }
                else if (choice == "client")
                {
                    new Client.Client().start();    //Creates a new client and starts it
                }
            }
        }
    }
}
