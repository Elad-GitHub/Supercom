using System.ServiceProcess;

namespace UsersManagerService
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            
            ServicesToRun = new ServiceBase[]
            {
                new UserManagerService()
            };

            ServiceBase.Run(ServicesToRun);
        }
    }
}
