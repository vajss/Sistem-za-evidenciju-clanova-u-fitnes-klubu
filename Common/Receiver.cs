using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    public class Receiver
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Receiver(Socket socket)
        {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public object Receive()
        {
            return formatter.Deserialize(stream);
        }
    }
}
