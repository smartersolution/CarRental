using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Install;

namespace CarRental.InventoryService.WinServiceHost
{

    [RunInstaller(true)]
    public class AccountServiceInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public AccountServiceInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            //service.Description = "Car Rental Account Manager Service.";
            service = new ServiceInstaller();
            service.ServiceName = "CarRentalAccountService";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
