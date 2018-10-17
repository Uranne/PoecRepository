using System;
using System.Runtime.Serialization;

namespace Demo
{
    [Serializable]
    internal class VehiculeException : Exception
    {
        public VehiculeException()
        {
        }

        public VehiculeException(string message) : base(message)
        {
        }

        public VehiculeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehiculeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}