using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using CarRental.Business.Bootstrapper;
using CarRental.Business.Entities;
using CarRental.Business.Managers;
using CarRental.Common;
using Core.Common.Core;
using System.Threading;
using System.Security.Principal;
using System.Transactions;
using System.ServiceProcess;
using System.ServiceModel;

namespace CarRental.RentalService.WinServiceHost
{
    public partial class RentalServiceHost : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public RentalServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the AccountManager type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(RentalManager)); 

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
