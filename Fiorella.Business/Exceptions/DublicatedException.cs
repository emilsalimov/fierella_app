using System.Net;

namespace Fiorella.Persistence.Exceptions
{
    public sealed class DublicatedException : Exception, IBaseExceptions
    {
        public int StatusCode { get; set;}

        public string CustomMessage { get; set;}
        public DublicatedException(string message): base(message)
        {
            StatusCode=(int)HttpStatusCode.Conflict; 
            CustomMessage=message;
        }
    }
}
