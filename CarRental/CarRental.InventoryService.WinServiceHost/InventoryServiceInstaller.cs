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
    public class InventoryServiceInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public InventoryServiceInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            //service.Description = "Car Rental Inventory Manager Service.";
            service = new ServiceInstaller();
            service.ServiceName = "CarRentalInventoryService";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
