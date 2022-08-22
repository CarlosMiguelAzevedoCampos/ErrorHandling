using System.Runtime.Serialization;

namespace CMA.ErrorHandling.Exceptions.Execptions
{
    public class AppErrorException : Exception
    {
        public AppErrorException()
        {
        }

        public AppErrorException(string? message) : base(message)
        {
        }

        public AppErrorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AppErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}