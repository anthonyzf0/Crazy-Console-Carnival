using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.Client
{
    class Client
    {
        //Connection Data
        private int port = 13000;
        private TcpClient client;
        private NetworkStream stream;

        //Used for data transfer
        private static Byte[] bytes = new Byte[1024];
        
        //Called to create a new client
        public Client(bool useLocal = false)
        {
            //Gets ip you want to connect to
            String ip = "";

            if (useLocal)
                ip = Server.Server.GetLocalIPAddress(true);
            else
            {
                Console.WriteLine("What IP is the server hosted on?");
                ip = Console.ReadLine();
            }

            //Connects to the server
            client = new TcpClient(ip, port);
            stream = client.GetStream();
        }

        //Gets all the commands the server has sent
        public String[] getServerData()
        {
            int d = stream.Read(bytes, 0, bytes.Length);
            String data = Encoding.ASCII.GetString(bytes, 0, d);
            
            return data.Split('`');
        }

        //Sends a message to the server
        public void sendMsg(String s)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(s);
            stream.Write(data, 0, data.Length);
        }
        
        //Called to show text from the server, color change is delt with her too
        public void displayText(String text)
        {
            String[] parts = text.Split('|');

            foreach (String part in parts)
            {
                String value = part;

                if (parts[0]!=part && part.Length > 1)
                {
                    try
                    {
                        int a = Convert.ToInt32(part[0] + "", 16);
                        int b = Convert.ToInt32(part[1] + "", 16);
                        Console.ForegroundColor = (ConsoleColor)a;
                        Console.BackgroundColor = (ConsoleColor)b;
                    }
                    catch
                    {
                        
                    }

                    value = value.Substring(2);
                }

                Console.Write(value);
            }

        }

        //Runs the client itself
        public void start()
        {
            //Clears the screen and opens a welcome message
            Console.Clear();
            while (true)
            {
                //Gets the data from the server
                String[] data = getServerData();

                foreach (string s in data) {

                    if (s == "") continue;

                    String type = s.Substring(0, 4);

                    switch (type)
                    {
                        //Server wants to read some client data
                        case "read":

                            sendMsg(Console.ReadLine());

                            break;

                        case "rkey":

                            sendMsg(((int)Console.ReadKey().Key).ToString());

                            break;

                        //Server wants to display some text
                        case "show":

                            displayText(s.Substring(4)+"\n");

                            break;

                        //Server wants to write some text
                        case "writ":

                            displayText(s.Substring(4));

                            break;

                        //Beep
                        case "beep":

                            String[] vals = s.Split(' ');
                            
                            Console.Beep(Convert.ToInt16(vals[1]), (int)(Convert.ToDouble(vals[2])*1000));
                            
                            break;

                        case "cler":

                            Console.Clear();

                            break;
                            
                    }
                }
            }
        }

        
    }
    
}
