using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Install;

namespace CarRental.RentalService.WinServiceHost
{

    [RunInstaller(true)]
    public class RentalServiceInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public RentalServiceInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            //service.Description = "Car Rental Manager Service.";
            service = new ServiceInstaller();
            service.ServiceName = "CarRentalService";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
