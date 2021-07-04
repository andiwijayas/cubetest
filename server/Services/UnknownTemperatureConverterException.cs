using System;
using System.Runtime.Serialization;

namespace server.Services
{
    [Serializable]
    internal class UnknownTemperatureConverterException : Exception
    {
        public UnknownTemperatureConverterException()
        {
        }

        public UnknownTemperatureConverterException(string message) : base(message)
        {
        }

        public UnknownTemperatureConverterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownTemperatureConverterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}