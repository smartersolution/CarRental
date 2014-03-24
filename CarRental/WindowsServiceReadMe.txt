We have following three windows services created  :
1.CarRental.AccountService.WinServiceHost
2.CarRental.InventoryService.WinServiceHost
3.CarRental.RentalService.WinServiceHost

The windows services need to be installed in order to run. 
Go through following steps for each service to install it:
1. Open Visual Studio command prompt in Admin Mode
2. Go to specific service project folder
3. Run following command to install service :
    instalutill bin\debug\CarRental.RentalService.WinServiceHost
4. Whenever you make a code change in Windows service, you need to first uninstall old service using following command :
    instalutill -u bin\debug\CarRental.RentalService.WinServiceHost
    Make changes in project and reinstall service using following command:
	instalutill bin\debug\CarRental.RentalService.WinServiceHost
