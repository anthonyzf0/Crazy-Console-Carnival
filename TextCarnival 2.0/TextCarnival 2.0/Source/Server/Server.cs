using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TextCarnivalV2.Source.CarnivalGames;

namespace TextCarnivalV2.Source.Server
{
    class Server
    {   
        //Basic Server information
        private static int port = 13000;
        private static TcpListener server;
        private static IPAddress localAddr;

        //All the clients on the server currently
        private static List<ServerConnection> clients;

        //The thread this is running on
        private static Thread run;

        //Called to start up the server
        public static void startServer()
        {
            Console.WriteLine("Running server");
            //Server
            clients = new List<ServerConnection>();

            //Gets ip
            String ip = GetLocalIPAddress(ServerConnection.runningDebug);
            
            localAddr = IPAddress.Parse(ip);
            Console.WriteLine("Starting server on ip: " + ip) ;

            //Create server object
            server = new TcpListener(localAddr, port);

            server.Start();
            
            run = new Thread(new ThreadStart(runServer));
            run.Start();
            Console.WriteLine("Server started");
        }

        //Gets local ip
        public static string GetLocalIPAddress(bool first)
        {
            List<String> ips = new List<string>();
            var host = Dns.GetHostAddresses(Dns.GetHostName());
            
            foreach (var ip in host)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ips.Add(ip.ToString());
                }
            }
            if (first)
                return ips[0];

            //Show possible ips
            Console.WriteLine("What Ip will you host on?");
            for (int i = 0; i < ips.Count; i++)
                Console.WriteLine("[{0}] : {1}", i+1, ips[i]);

            while (true)
            {
                String val = Console.ReadLine();
                int index = -1;
                int.TryParse(val, out index);

                if (index < 1 || index > ips.Count)
                {
                    Console.WriteLine("Not a ip");
                    continue;
                }
                return ips[index-1];
            }
            
        }
        
        //Runs the server itself
        public static void runServer()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                //Creact a client for our connection
                ServerConnection c = new ServerConnection(client.GetStream());
                clients.Add(c);
            }
        }

    }

    //2nd class in file, a new instance is created to store each individual client connected
    class ServerConnection
    {
        public static bool runningDebug = false;

        private CarnivalGame[] allGames;

        //Network data
        private NetworkStream stream;
        private Byte[] bytes;
        
        //Thread for connection
        private Thread run;

        public ServerConnection (NetworkStream connection)
        {
            stream = connection;
            loadGames();

            //Run it
            run = new Thread(new ThreadStart(runClient));
            run.Start();

        }

        private void loadGames()
        {
            //Gets all the types within the "Carnival games" file
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();
            Type[] typeList = allTypes.Where(t => String.Equals(t.Namespace, "TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames", StringComparison.Ordinal)).ToArray();

            //Seperates and parses those types into those of Carnival Game
            allGames = typeList.Where( i=>i.BaseType.Name == "CarnivalGame").Select(i => (CarnivalGame)Activator.CreateInstance(i)).ToArray();

        }

        //Sends data out to a client
        private bool send(String data)
        {
            //Uses [`] to split commands because its an uncommon character
            bytes = Encoding.ASCII.GetBytes("`" + data + "`");
            stream.Write(bytes, 0, bytes.Length);

            return true;
        }

        //Reads the data from the client
        public String readData()
        {
            send("read");
            bytes = new Byte[1024];
            int i = stream.Read(bytes, 0, bytes.Length);
            String data = (Encoding.ASCII.GetString(bytes, 0, i));

            return data;
        }

        public ConsoleKey readKey()
        {
            send("rkey");

            bytes = new Byte[1024];
            int i = stream.Read(bytes, 0, bytes.Length);
            String data = (Encoding.ASCII.GetString(bytes, 0, i));

            int key = 0;
            if (int.TryParse(data, out key))
                return (ConsoleKey)key;

            return ConsoleKey.PrintScreen;
        }

        //Writes data
        public bool writeData(String data)
        {
            send("show" + data);
            return true;
        }

        //Runs the server
        public void runClient()
        {
            if (!runningDebug)
                try
                {
                    play();
                }
                catch
                {
                    Console.WriteLine("ERROR...ERROR...CARNIVAL GAME CAUGHT ON FIRE!");
                    Console.WriteLine("(there was an error in the carnival game code)");
                    Console.WriteLine("(run this in debug mode to get an error message)");
                }
            else
                play();
        }

        //Actualy runs the client data
        private void play()
        {
            //If you run this as a server then write some basic info out
            if (!runningDebug)
                Console.WriteLine("Client joined!");

            while (true)
            {
                loadGames();
                
                writeData("===================================================================");
                writeData("|a0WELCOME TO THE TEXT CARNIVAL WHERE ALL YOUR TEXT DREAMS COME TRUE!|f0");
                writeData("===================================================================");

                writeData("\nGames at this carnival:");

                for (int i = 0; i < allGames.Length; i++)
                    writeData("[" + (i+1) + "] " + allGames[i].getName());

                writeData("Choose your carnival game: ");
                
                String val = readData();
                int index = -1;
                int.TryParse(val,out index);

                if (index < 1 || index > allGames.Length)
                {
                    writeData("Thats not a game, bud");
                    continue;
                }

                if (!runningDebug)
                    Console.WriteLine("Client playing game ({0})", allGames[index - 1].getName());

                allGames[index-1].setup(send, readData, readKey);
                allGames[index-1].play();

                //Resets the color data
                writeData("|f0");
            }

        }

    }
}
