using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    public class Sender
    {
        private readonly NetworkStream stream;
        private readonly BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send(object message)
        {
            formatter.Serialize(stream, message);
        }
    }
}
