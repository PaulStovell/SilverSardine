using System.ServiceProcess;

namespace SilverSardine.WindowsService
{
    partial class SampleService : ServiceBase
    {
        public SampleService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {

        }
    }
}
