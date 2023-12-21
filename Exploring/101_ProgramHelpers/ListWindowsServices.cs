using System.Management;

namespace Exploring._101_ProgramHelpers
{
    internal static class ListWindowsServices
    {
        internal static void ListAllWindowsServices()
        {
            ManagementObjectSearcher windowsServicesSearcher = new ManagementObjectSearcher("root\\cimv2", "select * from Win32_Service");
            ManagementObjectCollection objectCollection = windowsServicesSearcher.Get();


            windowsServicesSearcher.Get();

            Console.WriteLine("There are {0} Windows services: ", objectCollection.Count);

            foreach (ManagementObject windowsService in objectCollection)
            {
                PropertyDataCollection serviceProperties = windowsService.Properties;
                foreach (PropertyData serviceProperty in serviceProperties)
                {
                    if (serviceProperty.Value != null)
                    {
                        Console.WriteLine("Windows service property name: {0}", serviceProperty.Name);
                        Console.WriteLine("Windows service property value: {0}", serviceProperty.Value);
                    }
                }
            }
        }
    }
}