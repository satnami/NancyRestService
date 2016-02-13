using System;
using Nancy;
using Nancy.Hosting.Self;

namespace RestNancy.Server
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = parameters => { return "Hello"; };
            Get["/name"] = parameters => { return "Sami"; };
            Post["/names"] = paramsters => { return "Sami Post"; };
            Post["/names/{username}"] = parameters => { return "Hello " + (string)parameters.username; };

            //return Views
            //Get["/login"] = parameters => { return View["login"]; };
            
            Get["/404"] = parameters => { return Response.AsRedirect("/"); };
        }
    }
    public class RestServer
    {
        private readonly NancyHost _host = new NancyHost(new Uri("http://localhost:8050"));
        public void Start()
        {
            _host.Start();
        }

        public void Stop()
        {
            _host.Stop();
        }
    }
}
