using System;
using System.Runtime.Serialization;

namespace FacebookCustomAppEngine
{
    [Serializable]
    internal class UserWasNotSetException : Exception
    {
        public UserWasNotSetException()
        {
        }

        public UserWasNotSetException(string message) : base(message)
        {
        }

        public UserWasNotSetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserWasNotSetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}