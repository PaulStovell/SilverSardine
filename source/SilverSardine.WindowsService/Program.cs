using System.ServiceProcess;

namespace SilverSardine.WindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicesToRun = new ServiceBase[] 
            { 
                new SampleService(),  
            };

            ServiceBase.Run(servicesToRun);
        }
    }
}
