using RestNancy.Server;

namespace RestNancy.Console
{
    class Program
    {
        static RestServer _server = new RestServer();
        static void Main(string[] args)
        {
            _server.Start();

            while (true)
            {
                if(System.Console.ReadLine() != "q") _server.Stop();
            }

        }
    }
}
