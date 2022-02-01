using BasicWebServer.Server;

namespace MyWebServer.Demo
{
    public class Startup
    {
        static void Main()
        {
            var server = new HttpServer("127.0.0.1", 8080);
            server.Start();
        }
    }
}