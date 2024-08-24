using System;

namespace View.Exceptions
{
    public class SystemOperationException : Exception
    {
        public SystemOperationException() : base("Server ne može da obradi zahtev!")
        {

        }
        public SystemOperationException(string message) : base(message)
        {

        }
    }
}
