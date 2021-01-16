using System;
using System.Linq;
using System.Text;
using HidLibrary;
using System.IO;
namespace MagtekCardReader
{
    class Program
    {
        private const int VendorId = 0xFFFF;
        private const int ProductId = 0x0035;

        private static HidDevice _device;

        static void Main()
        {
            
                _device = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();

                if (_device != null)
                {
                    _device.OpenDevice();

                    _device.Inserted += DeviceAttachedHandler;
                    _device.Removed += DeviceRemovedHandler;

                    _device.MonitorDeviceEvents = true;

            //       _device.ReadReport(OnReport);
                    while(_device.IsConnected)
                    {
                   
                        Console.WriteLine("Reader found, press any key to exit.");
                    string s = Console.ReadLine();
                    if(s != "" && s!= null)
                        File.WriteAllText("D:\\Material\\SIU_LYTHUYET\\CNPTPMTT\\Parking_Basic\\parktext.txt", s);
                }               



                    _device.CloseDevice();
                    }
                else
                {
                    Console.WriteLine("Could not find reader.");
                    Console.ReadKey();
                }
            
           
           
        }

        private static void OnReport(HidReport report)
        {
            if (!_device.IsConnected) { return; }

            var cardData = new Data(report.Data);

            Console.WriteLine(!cardData.Error ? Encoding.ASCII.GetString(cardData.CardData) : cardData.ErrorMessage);

            _device.ReadReport(OnReport);
        }

        private static void DeviceAttachedHandler()
        {
            Console.WriteLine("Device attached.");
       //     _device.ReadReport(OnReport);
        }

        private static void DeviceRemovedHandler()
        {
            Console.WriteLine("Device removed.");
        }
    }
}
