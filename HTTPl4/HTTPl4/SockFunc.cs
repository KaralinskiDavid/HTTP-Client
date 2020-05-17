using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

 namespace HTTPl4
  {
        public class SockFunc
        {
            
            public Socket Connect(string adress)
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(adress,80);
                return socket;
            }

            public bool IsSocketConnected(Socket socket)
            {
            bool connected = true;
            bool blockingState = socket.Blocking;
            try
            {
                byte[] tmp = new byte[1];
                socket.Blocking = false;
                socket.Send(tmp, 0, 0);
            }
            catch(SocketException e)
            {
                connected = false;
            }
            finally
            {
                socket.Blocking = blockingState;
            }
            return connected;
            }
                
            
        }
 }
