using System.Runtime.Serialization;

namespace SmartQuiz.Controllers
{
    [Serializable]
    internal class HttpResponseException : Exception
    {
        private object unsupportedMediaType;

        public HttpResponseException()
        {
        }

        public HttpResponseException(object unsupportedMediaType)
        {
            this.unsupportedMediaType = unsupportedMediaType;
        }

        public HttpResponseException(string? message) : base(message)
        {
        }

        public HttpResponseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}