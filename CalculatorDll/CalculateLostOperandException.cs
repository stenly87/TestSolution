using System;
using System.Runtime.Serialization;

namespace CalculatorDll
{
    [Serializable]
    public class CalculateLostOperandException : Exception
    {
        public CalculateLostOperandException()
        {
        }

        public CalculateLostOperandException(string message) : base(message)
        {
        }

        public CalculateLostOperandException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CalculateLostOperandException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}