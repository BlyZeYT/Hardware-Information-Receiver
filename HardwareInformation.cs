namespace HardwareInfo
{
    /// <summary>
    /// Hardware Information class
    /// </summary>
    public class HardwareInformation
    {
        private readonly Hardware.Info.IHardwareInfo _hardwareInfo = new Hardware.Info.HardwareInfo();

        /// <summary>
        /// Get information about Batteries synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Battery"/> object</returns>
        public List<Battery> GetBatteriesInfo()
        {
            _hardwareInfo.RefreshBatteryList();
            var batteries = new List<Battery>();
            foreach (var battery in _hardwareInfo.BatteryList)
            {
                batteries.Add(new Battery
                {
                    BatteryStatus = battery.BatteryStatus,
                    BatteryStatusDescription = battery.BatteryStatusDescription,
                    DesignCapacity = battery.DesignCapacity,
                    EstimatedChargeRemaining = battery.EstimatedChargeRemaining,
                    EstimatedRunTime = battery.EstimatedRunTime,
                    ExpectedLife = battery.ExpectedLife,
                    FullChargeCapacity = battery.FullChargeCapacity,
                    MaxRechargeTime = battery.MaxRechargeTime,
                    TimeOnBattery = battery.TimeOnBattery,
                    TimeToFullCharge = battery.TimeToFullCharge
                });
            }
            return batteries;
        }

        /// <summary>
        /// Get information about Batteries asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Battery"/> object</returns>
        public Task<List<Battery>> GetBatteriesInfoAsync()
        {
            var task = new TaskCompletionSource<List<Battery>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshBatteryList();
                var batteries = new List<Battery>();
                foreach (var battery in _hardwareInfo.BatteryList)
                {
                    batteries.Add(new Battery
                    {
                        BatteryStatus = battery.BatteryStatus,
                        BatteryStatusDescription = battery.BatteryStatusDescription,
                        DesignCapacity = battery.DesignCapacity,
                        EstimatedChargeRemaining = battery.EstimatedChargeRemaining,
                        EstimatedRunTime = battery.EstimatedRunTime,
                        ExpectedLife = battery.ExpectedLife,
                        FullChargeCapacity = battery.FullChargeCapacity,
                        MaxRechargeTime = battery.MaxRechargeTime,
                        TimeOnBattery = battery.TimeOnBattery,
                        TimeToFullCharge = battery.TimeToFullCharge
                    });
                }
                task.SetResult(batteries);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about BIOS synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="BIOS"/> object</returns>
        public List<BIOS> GetBIOSInfo()
        {
            _hardwareInfo.RefreshBIOSList();
            var biosList = new List<BIOS>();
            foreach (var bios in _hardwareInfo.BiosList)
            {
                biosList.Add(new BIOS
                {
                    Caption = bios.Caption,
                    Description = bios.Description,
                    Manufacturer = bios.Manufacturer,
                    Name = bios.Name,
                    ReleaseDate = bios.ReleaseDate,
                    SerialNumber = bios.SerialNumber,
                    SoftwareElementID = bios.SoftwareElementID,
                    Version = bios.Version
                });
            }
            return biosList;
        }

        /// <summary>
        /// Get information about BIOS asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="BIOS"/> object</returns>
        public Task<List<BIOS>> GetBIOSInfoAsync()
        {
            var task = new TaskCompletionSource<List<BIOS>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshBIOSList();
                var biosList = new List<BIOS>();
                foreach (var bios in _hardwareInfo.BiosList)
                {
                    biosList.Add(new BIOS
                    {
                        Caption = bios.Caption,
                        Description = bios.Description,
                        Manufacturer = bios.Manufacturer,
                        Name = bios.Name,
                        ReleaseDate = bios.ReleaseDate,
                        SerialNumber = bios.SerialNumber,
                        SoftwareElementID = bios.SoftwareElementID,
                        Version = bios.Version
                    });
                }
                task.SetResult(biosList);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about CPUs synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="CPU"/> object</returns>
        public List<CPU> GetCPUsInfo()
        {
            _hardwareInfo.RefreshCPUList();
            var cpus = new List<CPU>();
            foreach (var cpu in _hardwareInfo.CpuList)
            {
                cpus.Add(new CPU
                {
                    Caption = cpu.Caption,
                    CpuCoreList = cpu.CpuCoreList,
                    CurrentClockSpeed = cpu.CurrentClockSpeed,
                    Description = cpu.Description,
                    L2CacheSize = cpu.L2CacheSize,
                    L3CacheSize = cpu.L3CacheSize,
                    Manufacturer = cpu.Manufacturer,
                    MaxClockSpeed = cpu.MaxClockSpeed,
                    Name = cpu.Name,
                    NumberOfCores = cpu.NumberOfCores,
                    NumberOfLogicalProcessors = cpu.NumberOfLogicalProcessors,
                    PercentProcessorTime = cpu.PercentProcessorTime,
                    ProcessorId = cpu.ProcessorId,
                    SecondLevelAddressTranslationExtensions = cpu.SecondLevelAddressTranslationExtensions,
                    SocketDesignation = cpu.SocketDesignation,
                    VirtualizationFirmwareEnabled = cpu.VirtualizationFirmwareEnabled,
                    VMMonitorModeExtensions = cpu.VMMonitorModeExtensions
                });
            }
            return cpus;
        }

        /// <summary>
        /// Get information about CPUs asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="CPU"/> object</returns>
        public Task<List<CPU>> GetCPUsInfoAsync()
        {
            var task = new TaskCompletionSource<List<CPU>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshCPUList();
                var cpus = new List<CPU>();
                foreach (var cpu in _hardwareInfo.CpuList)
                {
                    cpus.Add(new CPU
                    {
                        Caption = cpu.Caption,
                        CpuCoreList = cpu.CpuCoreList,
                        CurrentClockSpeed = cpu.CurrentClockSpeed,
                        Description = cpu.Description,
                        L2CacheSize = cpu.L2CacheSize,
                        L3CacheSize = cpu.L3CacheSize,
                        Manufacturer = cpu.Manufacturer,
                        MaxClockSpeed = cpu.MaxClockSpeed,
                        Name = cpu.Name,
                        NumberOfCores = cpu.NumberOfCores,
                        NumberOfLogicalProcessors = cpu.NumberOfLogicalProcessors,
                        PercentProcessorTime = cpu.PercentProcessorTime,
                        ProcessorId = cpu.ProcessorId,
                        SecondLevelAddressTranslationExtensions = cpu.SecondLevelAddressTranslationExtensions,
                        SocketDesignation = cpu.SocketDesignation,
                        VirtualizationFirmwareEnabled = cpu.VirtualizationFirmwareEnabled,
                        VMMonitorModeExtensions = cpu.VMMonitorModeExtensions
                    });
                }
                task.SetResult(cpus);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Drives synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Drive"/> object</returns>
        public List<Drive> GetDrivesInfo()
        {
            _hardwareInfo.RefreshDriveList();
            var drives = new List<Drive>();
            foreach (var drive in _hardwareInfo.DriveList)
            {
                drives.Add(new Drive
                {
                    Caption = drive.Caption,
                    Description = drive.Description,
                    FirmwareRevision = drive.FirmwareRevision,
                    Index = drive.Index,
                    Manufacturer = drive.Manufacturer,
                    Model = drive.Model,
                    Name = drive.Name,
                    PartitionList = drive.PartitionList,
                    Partitions = drive.Partitions,
                    SerialNumber = drive.SerialNumber,
                    Size = drive.Size
                });
            }
            return drives;
        }

        /// <summary>
        /// Get information about Drives asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Drive"/> object</returns>
        public Task<List<Drive>> GetDrivesInfoAsync()
        {
            var task = new TaskCompletionSource<List<Drive>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshDriveList();
                var drives = new List<Drive>();
                foreach (var drive in _hardwareInfo.DriveList)
                {
                    drives.Add(new Drive
                    {
                        Caption = drive.Caption,
                        Description = drive.Description,
                        FirmwareRevision = drive.FirmwareRevision,
                        Index = drive.Index,
                        Manufacturer = drive.Manufacturer,
                        Model = drive.Model,
                        Name = drive.Name,
                        PartitionList = drive.PartitionList,
                        Partitions = drive.Partitions,
                        SerialNumber = drive.SerialNumber,
                        Size = drive.Size
                    });
                }
                task.SetResult(drives);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Keyboards synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Keyboard"/> object</returns>
        public List<Keyboard> GetKeyboardsInfo()
        {
            _hardwareInfo.RefreshKeyboardList();
            var keyboards = new List<Keyboard>();
            foreach (var keyboard in _hardwareInfo.KeyboardList)
            {
                keyboards.Add(new Keyboard
                {
                    Caption = keyboard.Caption,
                    Description = keyboard.Description,
                    Name = keyboard.Name,
                    NumberOfFunctionKeys = keyboard.NumberOfFunctionKeys
                });
            }
            return keyboards;
        }

        /// <summary>
        /// Get information about Keyboards asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Keyboard"/> object</returns>
        public Task<List<Keyboard>> GetKeyboardsInfoAsync()
        {
            var task = new TaskCompletionSource<List<Keyboard>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshKeyboardList();
                var keyboards = new List<Keyboard>();
                foreach (var keyboard in _hardwareInfo.KeyboardList)
                {
                    keyboards.Add(new Keyboard
                    {
                        Caption = keyboard.Caption,
                        Description = keyboard.Description,
                        Name = keyboard.Name,
                        NumberOfFunctionKeys = keyboard.NumberOfFunctionKeys
                    });
                }
                task.SetResult(keyboards);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Memories synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Memory"/> object</returns>
        public List<Memory> GetMemoriesInfo()
        {
            _hardwareInfo.RefreshMemoryList();
            var memories = new List<Memory>();
            foreach (var memory in _hardwareInfo.MemoryList)
            {
                memories.Add(new Memory
                {
                    BankLabel = memory.BankLabel,
                    Capacity = memory.Capacity,
                    FormFactor = memory.FormFactor,
                    Manufacturer = memory.Manufacturer,
                    MaxVoltage = memory.MaxVoltage,
                    MinVoltage = memory.MinVoltage,
                    PartNumber = memory.PartNumber,
                    SerialNumber = memory.SerialNumber,
                    Speed = memory.Speed
                });
            }
            return memories;
        }

        /// <summary>
        /// Get information about Memories asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Memory"/> object</returns>
        public Task<List<Memory>> GetMemoriesInfoAsync()
        {
            var task = new TaskCompletionSource<List<Memory>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshMemoryList();
                var memories = new List<Memory>();
                foreach (var memory in _hardwareInfo.MemoryList)
                {
                    memories.Add(new Memory
                    {
                        BankLabel = memory.BankLabel,
                        Capacity = memory.Capacity,
                        FormFactor = memory.FormFactor,
                        Manufacturer = memory.Manufacturer,
                        MaxVoltage = memory.MaxVoltage,
                        MinVoltage = memory.MinVoltage,
                        PartNumber = memory.PartNumber,
                        SerialNumber = memory.SerialNumber,
                        Speed = memory.Speed
                    });
                }
                task.SetResult(memories);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Memory Status synchronously
        /// </summary>
        /// <returns>Returns a <see cref="MemoryStatus"/> object</returns>
        public MemoryStatus GetMemoryStatusInfo()
        {
            _hardwareInfo.RefreshMemoryStatus();
            var status = new MemoryStatus
            {
                AvailableExtendedVirtual = _hardwareInfo.MemoryStatus.AvailableExtendedVirtual,
                AvailablePageFile = _hardwareInfo.MemoryStatus.AvailablePageFile,
                AvailablePhysical = _hardwareInfo.MemoryStatus.AvailablePhysical,
                AvailableVirtual = _hardwareInfo.MemoryStatus.AvailableVirtual,
                TotalPageFile = _hardwareInfo.MemoryStatus.TotalPageFile,
                TotalPhysical = _hardwareInfo.MemoryStatus.TotalPhysical,
                TotalVirtual = _hardwareInfo.MemoryStatus.TotalVirtual
            };
            return status;
        }

        /// <summary>
        /// Get information about Memory Status asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="MemoryStatus"/> object</returns>
        public Task<MemoryStatus> GetMemoryStatusInfoAsync()
        {
            var task = new TaskCompletionSource<MemoryStatus>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshMemoryStatus();
                var status = new MemoryStatus
                {
                    AvailableExtendedVirtual = _hardwareInfo.MemoryStatus.AvailableExtendedVirtual,
                    AvailablePageFile = _hardwareInfo.MemoryStatus.AvailablePageFile,
                    AvailablePhysical = _hardwareInfo.MemoryStatus.AvailablePhysical,
                    AvailableVirtual = _hardwareInfo.MemoryStatus.AvailableVirtual,
                    TotalPageFile = _hardwareInfo.MemoryStatus.TotalPageFile,
                    TotalPhysical = _hardwareInfo.MemoryStatus.TotalPhysical,
                    TotalVirtual = _hardwareInfo.MemoryStatus.TotalVirtual
                };
                task.SetResult(status);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Monitors synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Monitor"/> object</returns>
        public List<Monitor> GetMonitorsInfo()
        {
            _hardwareInfo.RefreshMonitorList();
            var monitors = new List<Monitor>();
            foreach (var monitor in _hardwareInfo.MonitorList)
            {
                monitors.Add(new Monitor
                {
                    Caption = monitor.Caption,
                    Description = monitor.Description,
                    MonitorManufacturer = monitor.MonitorManufacturer,
                    MonitorType = monitor.MonitorType,
                    Name = monitor.Name,
                    PixelsPerXLogicalInch = monitor.PixelsPerXLogicalInch,
                    PixelsPerYLogicalInch = monitor.PixelsPerYLogicalInch
                });
            }
            return monitors;
        }

        /// <summary>
        /// Get information about Monitors asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Monitor"/> object</returns>
        public Task<List<Monitor>> GetMonitorsInfoAsync()
        {
            var task = new TaskCompletionSource<List<Monitor>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshMonitorList();
                var monitors = new List<Monitor>();
                foreach (var monitor in _hardwareInfo.MonitorList)
                {
                    monitors.Add(new Monitor
                    {
                        Caption = monitor.Caption,
                        Description = monitor.Description,
                        MonitorManufacturer = monitor.MonitorManufacturer,
                        MonitorType = monitor.MonitorType,
                        Name = monitor.Name,
                        PixelsPerXLogicalInch = monitor.PixelsPerXLogicalInch,
                        PixelsPerYLogicalInch = monitor.PixelsPerYLogicalInch
                    });
                }
                task.SetResult(monitors);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Motherboards synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Motherboard"/> object</returns>
        public List<Motherboard> GetMotherboardsInfo()
        {
            _hardwareInfo.RefreshMotherboardList();
            var motherboards = new List<Motherboard>();
            foreach (var motherboard in _hardwareInfo.MotherboardList)
            {
                motherboards.Add(new Motherboard
                {
                    Manufacturer = motherboard.Manufacturer,
                    Product = motherboard.Product,
                    SerialNumber = motherboard.SerialNumber
                });
            }
            return motherboards;
        }

        /// <summary>
        /// Get information about Motherboards asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Motherboard"/> object</returns>
        public Task<List<Motherboard>> GetMotherboardsInfoAsync()
        {
            var task = new TaskCompletionSource<List<Motherboard>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshMotherboardList();
                var motherboards = new List<Motherboard>();
                foreach (var motherboard in _hardwareInfo.MotherboardList)
                {
                    motherboards.Add(new Motherboard
                    {
                        Manufacturer = motherboard.Manufacturer,
                        Product = motherboard.Product,
                        SerialNumber = motherboard.SerialNumber
                    });
                }
                task.SetResult(motherboards);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Mice synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Mouse"/> object</returns>
        public List<Mouse> GetMiceInfo()
        {
            _hardwareInfo.RefreshMouseList();
            var mice = new List<Mouse>();
            foreach (var mouse in _hardwareInfo.MouseList)
            {
                mice.Add(new Mouse
                {
                    Caption = mouse.Caption,
                    Description = mouse.Description,
                    Manufacturer = mouse.Manufacturer,
                    Name = mouse.Name,
                    NumberOfButtons = mouse.NumberOfButtons
                });
            }
            return mice;
        }

        /// <summary>
        /// Get information about Mice asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Mouse"/> object</returns>
        public Task<List<Mouse>> GetMiceInfoAsync()
        {
            var task = new TaskCompletionSource<List<Mouse>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshMouseList();
                var mice = new List<Mouse>();
                foreach (var mouse in _hardwareInfo.MouseList)
                {
                    mice.Add(new Mouse
                    {
                        Caption = mouse.Caption,
                        Description = mouse.Description,
                        Manufacturer = mouse.Manufacturer,
                        Name = mouse.Name,
                        NumberOfButtons = mouse.NumberOfButtons
                    });
                }
                task.SetResult(mice);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Network Adapters synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="NetworkAdapter"/> object</returns>
        public List<NetworkAdapter> GetNetworkAdaptersInfo()
        {
            _hardwareInfo.RefreshNetworkAdapterList();
            var networkAdapters = new List<NetworkAdapter>();
            foreach (var networkAdapter in _hardwareInfo.NetworkAdapterList)
            {
                networkAdapters.Add(new NetworkAdapter
                {
                    AdapterType = networkAdapter.AdapterType,
                    BytesReceivedPersec = networkAdapter.BytesReceivedPersec,
                    BytesSentPersec = networkAdapter.BytesSentPersec,
                    Caption = networkAdapter.Caption,
                    DefaultIPGatewayList = networkAdapter.DefaultIPGatewayList,
                    Description = networkAdapter.Description,
                    DHCPServer = networkAdapter.DHCPServer,
                    DNSServerSearchOrderList = networkAdapter.DNSServerSearchOrderList,
                    IPAddressList = networkAdapter.IPAddressList,
                    IPSubnetList = networkAdapter.IPSubnetList,
                    MACAddress = networkAdapter.MACAddress,
                    Manufacturer = networkAdapter.Manufacturer,
                    Name = networkAdapter.Name,
                    NetConnectionID = networkAdapter.NetConnectionID,
                    ProductName = networkAdapter.ProductName,
                    Speed = networkAdapter.Speed
                });
            }
            return networkAdapters;
        }

        /// <summary>
        /// Get information about Network Adapters asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="NetworkAdapter"/> object</returns>
        public Task<List<NetworkAdapter>> GetNetworkAdaptersInfoAsync()
        {
            var task = new TaskCompletionSource<List<NetworkAdapter>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshNetworkAdapterList();
                var networkAdapters = new List<NetworkAdapter>();
                foreach (var networkAdapter in _hardwareInfo.NetworkAdapterList)
                {
                    networkAdapters.Add(new NetworkAdapter
                    {
                        AdapterType = networkAdapter.AdapterType,
                        BytesReceivedPersec = networkAdapter.BytesReceivedPersec,
                        BytesSentPersec = networkAdapter.BytesSentPersec,
                        Caption = networkAdapter.Caption,
                        DefaultIPGatewayList = networkAdapter.DefaultIPGatewayList,
                        Description = networkAdapter.Description,
                        DHCPServer = networkAdapter.DHCPServer,
                        DNSServerSearchOrderList = networkAdapter.DNSServerSearchOrderList,
                        IPAddressList = networkAdapter.IPAddressList,
                        IPSubnetList = networkAdapter.IPSubnetList,
                        MACAddress = networkAdapter.MACAddress,
                        Manufacturer = networkAdapter.Manufacturer,
                        Name = networkAdapter.Name,
                        NetConnectionID = networkAdapter.NetConnectionID,
                        ProductName = networkAdapter.ProductName,
                        Speed = networkAdapter.Speed
                    });
                }
                task.SetResult(networkAdapters);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Printers synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Printer"/> object</returns>
        public List<Printer> GetPrintersInfo()
        {
            _hardwareInfo.RefreshPrinterList();
            var printers = new List<Printer>();
            foreach (var printer in _hardwareInfo.PrinterList)
            {
                printers.Add(new Printer
                {
                    Caption = printer.Caption,
                    Default = printer.Default,
                    Description = printer.Description,
                    HorizontalResolution = printer.HorizontalResolution,
                    Local = printer.Local,
                    Name = printer.Name,
                    Network = printer.Network,
                    Shared = printer.Shared,
                    VerticalResolution = printer.VerticalResolution
                });
            }
            return printers;
        }

        /// <summary>
        /// Get information about Printers asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="Printer"/> object</returns>
        public Task<List<Printer>> GetPrintersInfoAsync()
        {
            var task = new TaskCompletionSource<List<Printer>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshPrinterList();
                var printers = new List<Printer>();
                foreach (var printer in _hardwareInfo.PrinterList)
                {
                    printers.Add(new Printer
                    {
                        Caption = printer.Caption,
                        Default = printer.Default,
                        Description = printer.Description,
                        HorizontalResolution = printer.HorizontalResolution,
                        Local = printer.Local,
                        Name = printer.Name,
                        Network = printer.Network,
                        Shared = printer.Shared,
                        VerticalResolution = printer.VerticalResolution
                    });
                }
                task.SetResult(printers);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Sound Devices synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="SoundDevice"/> object</returns>
        public List<SoundDevice> GetSoundDevicesInfo()
        {
            _hardwareInfo.RefreshSoundDeviceList();
            var soundDevices = new List<SoundDevice>();
            foreach (var soundDevice in _hardwareInfo.SoundDeviceList)
            {
                soundDevices.Add(new SoundDevice
                {
                    Caption = soundDevice.Caption,
                    Description = soundDevice.Description,
                    Manufacturer = soundDevice.Manufacturer,
                    Name = soundDevice.Name,
                    ProductName = soundDevice.ProductName
                });
            }
            return soundDevices;
        }

        /// <summary>
        /// Get information about Sound Devices asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="SoundDevice"/> object</returns>
        public Task<List<SoundDevice>> GetSoundDevicesInfoAsync()
        {
            var task = new TaskCompletionSource<List<SoundDevice>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshSoundDeviceList();
                var soundDevices = new List<SoundDevice>();
                foreach (var soundDevice in _hardwareInfo.SoundDeviceList)
                {
                    soundDevices.Add(new SoundDevice
                    {
                        Caption = soundDevice.Caption,
                        Description = soundDevice.Description,
                        Manufacturer = soundDevice.Manufacturer,
                        Name = soundDevice.Name,
                        ProductName = soundDevice.ProductName
                    });
                }
                task.SetResult(soundDevices);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about Video Controllers synchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="VideoController"/> object</returns>
        public List<VideoController> GetVideoControllersInfo()
        {
            _hardwareInfo.RefreshVideoControllerList();
            var videoControllers = new List<VideoController>();
            foreach (var videoController in _hardwareInfo.VideoControllerList)
            {
                videoControllers.Add(new VideoController
                {
                    AdapterRAM = videoController.AdapterRAM,
                    Caption = videoController.Caption,
                    CurrentBitsPerPixel = videoController.CurrentBitsPerPixel,
                    CurrentHorizontalResolution = videoController.CurrentHorizontalResolution,
                    CurrentNumberOfColors = videoController.CurrentNumberOfColors,
                    CurrentRefreshRate = videoController.CurrentRefreshRate,
                    CurrentVerticalResolution = videoController.CurrentVerticalResolution,
                    Description = videoController.Description,
                    DriverDate = videoController.DriverDate,
                    DriverVersion = videoController.DriverVersion,
                    Manufacturer = videoController.Manufacturer,
                    MaxRefreshRate = videoController.MaxRefreshRate,
                    MinRefreshRate = videoController.MinRefreshRate,
                    Name = videoController.Name,
                    VideoModeDescription = videoController.VideoModeDescription,
                    VideoProcessor = videoController.VideoProcessor
                });
            }
            return videoControllers;
        }

        /// <summary>
        /// Get information about Video Controllers asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="List{T}"/> of the <see cref="VideoController"/> object</returns>
        public Task<List<VideoController>> GetVideoControllersInfoAsync()
        {
            var task = new TaskCompletionSource<List<VideoController>>();
            Task.Run(() =>
            {
                _hardwareInfo.RefreshVideoControllerList();
                var videoControllers = new List<VideoController>();
                foreach (var videoController in _hardwareInfo.VideoControllerList)
                {
                    videoControllers.Add(new VideoController
                    {
                        AdapterRAM = videoController.AdapterRAM,
                        Caption = videoController.Caption,
                        CurrentBitsPerPixel = videoController.CurrentBitsPerPixel,
                        CurrentHorizontalResolution = videoController.CurrentHorizontalResolution,
                        CurrentNumberOfColors = videoController.CurrentNumberOfColors,
                        CurrentRefreshRate = videoController.CurrentRefreshRate,
                        CurrentVerticalResolution = videoController.CurrentVerticalResolution,
                        Description = videoController.Description,
                        DriverDate = videoController.DriverDate,
                        DriverVersion = videoController.DriverVersion,
                        Manufacturer = videoController.Manufacturer,
                        MaxRefreshRate = videoController.MaxRefreshRate,
                        MinRefreshRate = videoController.MinRefreshRate,
                        Name = videoController.Name,
                        VideoModeDescription = videoController.VideoModeDescription,
                        VideoProcessor = videoController.VideoProcessor
                    });
                }
                task.SetResult(videoControllers);
            });
            return task.Task;
        }

        /// <summary>
        /// Get information about all Hardware synchronously
        /// </summary>
        /// <returns>Returns a <see cref="AllHardware"/> object</returns>
        public AllHardware GetAllHardwareInfo()
        {
            var all = new AllHardware
            {
                Batteries = GetBatteriesInfo(),
                Bios = GetBIOSInfo(),
                CPUs = GetCPUsInfo(),
                Drives = GetDrivesInfo(),
                Keyboards = GetKeyboardsInfo(),
                Memories = GetMemoriesInfo(),
                MemoryStatus = GetMemoryStatusInfo(),
                Mice = GetMiceInfo(),
                Monitors = GetMonitorsInfo(),
                Motherboards = GetMotherboardsInfo(),
                NetworkAdapters = GetNetworkAdaptersInfo(),
                Printers = GetPrintersInfo(),
                SoundDevices = GetSoundDevicesInfo(),
                VideoControllers = GetVideoControllersInfo()
            };
            return all;
        }

        /// <summary>
        /// Get information about all Hardware asynchronously
        /// </summary>
        /// <returns>Returns a <see cref="AllHardware"/> object</returns>
        public Task<AllHardware> GetAllHardwareInfoAsync()
        {
            var task = new TaskCompletionSource<AllHardware>();
            Task.Run(async () =>
            {
                var all = new AllHardware
                {
                    Batteries = await GetBatteriesInfoAsync(),
                    Bios = await GetBIOSInfoAsync(),
                    CPUs = await GetCPUsInfoAsync(),
                    Drives = await GetDrivesInfoAsync(),
                    Keyboards = await GetKeyboardsInfoAsync(),
                    Memories = await GetMemoriesInfoAsync(),
                    MemoryStatus = await GetMemoryStatusInfoAsync(),
                    Mice = await GetMiceInfoAsync(),
                    Monitors = await GetMonitorsInfoAsync(),
                    Motherboards = await GetMotherboardsInfoAsync(),
                    NetworkAdapters = await GetNetworkAdaptersInfoAsync(),
                    Printers = await GetPrintersInfoAsync(),
                    SoundDevices = await GetSoundDevicesInfoAsync(),
                    VideoControllers = await GetVideoControllersInfoAsync()
                };
                task.SetResult(all);
            });
            return task.Task;
        }

        public class Battery
        {
            public ushort BatteryStatus { get; internal set; }
            public string BatteryStatusDescription { get; internal set; }
            public uint DesignCapacity { get; internal set; }
            public ushort EstimatedChargeRemaining { get; internal set; }
            public uint EstimatedRunTime { get; internal set; }
            public uint ExpectedLife { get; internal set; }
            public uint FullChargeCapacity { get; internal set; }
            public uint MaxRechargeTime { get; internal set; }
            public uint TimeOnBattery { get; internal set; }
            public uint TimeToFullCharge { get; internal set; }
        }

        public class BIOS
        {
            public string Caption { get; internal set; }
            public string Description { get; internal set; }
            public string Manufacturer { get; internal set; }
            public string Name { get; internal set; }
            public string ReleaseDate { get; internal set; }
            public string SerialNumber { get; internal set; }
            public string SoftwareElementID { get; internal set; }
            public string Version { get; internal set; }
        }

        public class CPU
        {
            public string Caption { get; internal set; }
            public List<Hardware.Info.CpuCore> CpuCoreList { get; internal set; }
            public uint CurrentClockSpeed { get; internal set; }
            public string Description { get; internal set; }
            public uint L2CacheSize { get; internal set; }
            public uint L3CacheSize { get; internal set; }
            public string Manufacturer { get; internal set; }
            public uint MaxClockSpeed { get; internal set; }
            public string Name { get; internal set; }
            public uint NumberOfCores { get; internal set; }
            public uint NumberOfLogicalProcessors { get; internal set; }
            public ulong PercentProcessorTime { get; internal set; }
            public string ProcessorId { get; internal set; }
            public bool SecondLevelAddressTranslationExtensions { get; internal set; }
            public string SocketDesignation { get; internal set; }
            public bool VirtualizationFirmwareEnabled { get; internal set; }
            public bool VMMonitorModeExtensions { get; internal set; }
        }

        public class Drive
        {
            public string Caption { get; internal set; }
            public string Description { get; internal set; }
            public string FirmwareRevision { get; internal set; }
            public uint Index { get; internal set; }
            public string Manufacturer { get; internal set; }
            public string Model { get; internal set; }
            public string Name { get; internal set; }
            public List<Hardware.Info.Partition> PartitionList { get; internal set; }
            public uint Partitions { get; internal set; }
            public string SerialNumber { get; internal set; }
            public ulong Size { get; internal set; }
        }

        public class Keyboard
        {
            public string Caption { get; internal set; }
            public string Description { get; internal set; }
            public string Name { get; internal set; }
            public ushort NumberOfFunctionKeys { get; internal set; }
        }

        public class Memory
        {
            public string BankLabel { get; internal set; }
            public ulong Capacity { get; internal set; }
            public Hardware.Info.FormFactor FormFactor { get; internal set; }
            public string Manufacturer { get; internal set;}
            public uint MaxVoltage { get; internal set; }
            public uint MinVoltage { get; internal set; }
            public string PartNumber { get; internal set; }
            public string SerialNumber { get; internal set; }
            public uint Speed { get; internal set; }
        }

        public class MemoryStatus
        {
            public ulong AvailableExtendedVirtual { get; internal set; }
            public ulong AvailablePageFile { get; internal set; }
            public ulong AvailablePhysical { get; internal set; }
            public ulong AvailableVirtual { get; internal set; }
            public ulong TotalPageFile { get; internal set; }
            public ulong TotalPhysical { get; internal set; }
            public ulong TotalVirtual { get; internal set; }
        }

        public class Monitor
        {
            public string Caption { get; internal set; }
            public string Description { get; internal set; }
            public string MonitorManufacturer { get; internal set; }
            public string MonitorType { get; internal set; }
            public string Name { get; internal set; }
            public uint PixelsPerXLogicalInch { get; internal set; }
            public uint PixelsPerYLogicalInch { get; internal set; }
        }

        public class Motherboard
        {
            public string Manufacturer { get; internal set; }
            public string Product { get; internal set; }
            public string SerialNumber { get; internal set; }
        }

        public class Mouse
        {
            public string Caption { get; internal set; }
            public string Description { get; internal set; }
            public string Manufacturer { get; internal set; }
            public string Name { get; internal set; }
            public byte NumberOfButtons { get; internal set; }
        }

        public class NetworkAdapter
        {
            public string AdapterType { get; internal set; }
            public ulong BytesReceivedPersec { get; internal set; }
            public ulong BytesSentPersec { get; internal set; }
            public string Caption { get; internal set; }
            public List<System.Net.IPAddress> DefaultIPGatewayList { get; internal set; }
            public string Description { get; internal set; }
            public System.Net.IPAddress DHCPServer { get; internal set; }
            public List<System.Net.IPAddress> DNSServerSearchOrderList { get; internal set; }
            public List<System.Net.IPAddress> IPAddressList { get; internal set; }
            public List<System.Net.IPAddress> IPSubnetList { get; internal set; }
            public string MACAddress { get; internal set; }
            public string Manufacturer { get; internal set; }
            public string Name { get; internal set; }
            public string NetConnectionID { get; internal set; }
            public string ProductName { get; internal set; }
            public ulong Speed { get; internal set; }
        }

        public class Printer
        {
            public string Caption { get; internal set; }
            public bool Default { get; internal set; }
            public string Description { get; internal set; }
            public uint HorizontalResolution { get; internal set; }
            public bool Local { get; internal set; }
            public string Name { get; internal set; }
            public bool Network { get; internal set; }
            public bool Shared { get; internal set; }
            public uint VerticalResolution { get; internal set; }
        }

        public class SoundDevice
        {
            public string Caption { get; internal set; }
            public string Description { get; internal set; }
            public string Manufacturer { get; internal set; }
            public string Name { get; internal set; }
            public string ProductName { get; internal set; }
        }

        public class VideoController
        {
            public uint AdapterRAM { get; internal set; }
            public string Caption { get; internal set; }
            public uint CurrentBitsPerPixel { get; internal set; }
            public uint CurrentHorizontalResolution { get; internal set; }
            public ulong CurrentNumberOfColors { get; internal set; }
            public uint CurrentRefreshRate { get; internal set; }
            public uint CurrentVerticalResolution { get; internal set; }
            public string Description { get; internal set; }
            public string DriverDate { get; internal set; }
            public string DriverVersion { get; internal set; }
            public string Manufacturer { get; internal set; }
            public uint MaxRefreshRate { get; internal set; }
            public uint MinRefreshRate { get; internal set; }
            public string Name { get; internal set; }
            public string VideoModeDescription { get; internal set; }
            public string VideoProcessor { get; internal set; }
        }

        public class AllHardware
        {
            public List<Battery> Batteries { get; internal set; }
            public List<BIOS> Bios { get; internal set; }
            public List<CPU> CPUs { get; internal set; }
            public List<Drive> Drives { get; internal set; }
            public List<Keyboard> Keyboards { get; internal set; }
            public List<Memory> Memories { get; internal set; }
            public MemoryStatus MemoryStatus { get; internal set; }
            public List<Monitor> Monitors { get; internal set; }
            public List<Motherboard> Motherboards { get; internal set; }
            public List<Mouse> Mice { get; internal set; }
            public List<NetworkAdapter> NetworkAdapters { get; internal set; }
            public List<Printer> Printers { get; internal set; }
            public List<SoundDevice> SoundDevices { get; internal set; }
            public List<VideoController> VideoControllers { get; internal set; }
        }
    }
}
