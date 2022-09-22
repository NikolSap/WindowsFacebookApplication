using System;
using System.Runtime.Serialization;

namespace LikesCounter
{
    [Serializable]
    internal class BedTypeException : Exception
    {
        public BedTypeException()
        {
        }

        public BedTypeException(string message) : base(message)
        {
        }

        public BedTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BedTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}