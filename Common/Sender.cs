using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    public class Sender
    {
        private readonly Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            this.socket = socket;
            this.stream = new NetworkStream(socket);
            this.formatter = new BinaryFormatter();
        }

        public void Send(object message)
        {
            formatter.Serialize(stream, message);
        }
    }
}
