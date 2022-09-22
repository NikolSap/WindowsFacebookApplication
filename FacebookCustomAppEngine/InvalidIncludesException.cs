using System;
using System.Runtime.Serialization;

namespace LikesCounter
{
    [Serializable]
    internal class InvalidIncludesException : Exception
    {
        public InvalidIncludesException()
        {
        }

        public InvalidIncludesException(string message) : base(message)
        {
        }

        public InvalidIncludesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidIncludesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}