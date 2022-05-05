# Hardware-Information-Receiver
## For .NET 6.0
Get Hardware information synchronously and asynchronously.

### Documentation

    Initialize the HardwareInformation class

    var hardware = new HardwareInformation();

    Get the list of CPUs (for example)

    var cpus = hardware.GetCPUsInfo(); //synchronously
    var cpusAsync = await hardware.GetCPUsInfoAsync(); //asynchronously

    Get the information of the CPUs

    var cpu = cpus[0]; //Save first CPU

    var coresNumber = cpu.NumberOfCores; //Get Numbers of Cores from saved CPU
