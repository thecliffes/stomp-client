using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSocketSharp;

namespace stomp_client
{
    class Program
    {
        static void Main(string[] args)
        {
            //created scroped instance of ws client that will be properly disposed of
            using (WebSocket ws = new WebSocket("ws://localhost:9000"))
            {
                ws.OnMessage += Ws_OnMessage;
                ws.Connect();

                Console.ReadKey();
            }
        }

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Recieved from the server " + e.Data);
        }
    }
}
