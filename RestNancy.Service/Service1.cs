using System.ServiceProcess;
using RestNancy.Server;

namespace RestNancy.Service
{
    public partial class Service1 : ServiceBase
    {
        RestServer _server = new RestServer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _server.Start();
        }

        protected override void OnStop()
        {
            _server.Stop();
        }
    }
}
