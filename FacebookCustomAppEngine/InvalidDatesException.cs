using System;
using System.Runtime.Serialization;

namespace LikesCounter
{
    [Serializable]
    internal class InvalidDatesException : Exception
    {
        public InvalidDatesException()
        {
        }

        public InvalidDatesException(string message) : base(message)
        {
        }

        public InvalidDatesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidDatesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}