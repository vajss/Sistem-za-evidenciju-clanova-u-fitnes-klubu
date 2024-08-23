using System;

namespace View.Exceptions
{
    public class SystemNotFoundException : Exception
    {
        public SystemNotFoundException() : base("Nalog nije pronađen, proverite kredencijale i pokušajte ponovo.")
        {

        }
        public SystemNotFoundException(string message) : base(message)
        {

        }
    }
}
