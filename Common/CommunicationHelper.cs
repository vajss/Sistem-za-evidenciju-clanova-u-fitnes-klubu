﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationHelper
    {
        private readonly NetworkStream stream;
        private readonly BinaryFormatter formatter;

        public CommunicationHelper(Socket socket)
        {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send<T>(T obj) where T : class
        {
            formatter.Serialize(stream, obj);
        }

        public T Receive<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }

    }
}
