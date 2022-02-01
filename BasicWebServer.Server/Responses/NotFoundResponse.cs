using BasicWebServer.Server.HTTP;

namespace BasicWebServer.Server.Responses
{
    public class NotFoundRequest : Response
    {
        public NotFoundRequest()
            : base(StatusCode.NotFound)
        {

        }
    }
}
