using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatDev
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var command = args[0].Trim();
            if(args!=null && args.Length > 0)
            {
                List<string> deviceCommandlist = new List<string>()
                {
                    "sn",
                    "bios",
                    "os",
                    "image",
                    "platform",
                    "wwan",
                    "wlan",
                    "lan",
                    "bt",
                    "nfc",
                    "rfid",
                    "all",
                    "export",
                    "?"
                };
                if(deviceCommandlist.GetRange(deviceCommandlist.IndexOf("wwan"), (deviceCommandlist.IndexOf("export") - deviceCommandlist.IndexOf("wwan"))).Contains(args[0]))
                {
                    CatUut.GetCommDev();
                }
                switch (command)
                {
                    case "sn":
                        Console.WriteLine(CatUut.SN);
                        break;
                    case "bios":
                        Console.WriteLine(CatUut.BIOS);
                        break;
                    case "os":
                        Console.WriteLine(CatUut.OS);
                        break;
                    case "image":
                        Console.WriteLine(CatUut.Image);
                        break;
                    case "platform":
                        Console.WriteLine(CatUut.Platform);
                        break;
                    case "wwan":
                        showWWan();
                        break;
                    case "wlan":
                        showWlan();
                        break;
                    case "lan":
                        showLan();
                        break;
                    case "bt":
                        showBt();
                        break;
                    case "nfc":
                        showNfc();
                        break;
                    case "rfid":
                        showRfid();
                        break;
                    case "all":
                        showWWan();
                        showWlan();
                        showLan();
                        showBt();
                        showNfc();
                        showRfid();
                        break;
                    case "export":
                        CatUut.GetCommDevConvertJson();
                        break;
                    case "?":
                        Console.WriteLine();
                        Console.WriteLine("arguments are :");
                        foreach (var arg in deviceCommandlist)
                        {
                            Console.WriteLine("\t" + arg);
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Visulize();
                        break;
                }
            }
            else
            {
                Visulize();
            }

            void Visulize()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new F1_Main());
            }

            #region show information
            void showWWan()
            {
                Console.WriteLine($"================WWAN================");
                Console.WriteLine();
                Console.WriteLine($"HWID:\t\t{CatUut.WWAN.name}");
                Console.WriteLine($"HWID:\t\t{CatUut.WWAN.hwid}");
                Console.WriteLine($"DRIVER:\t\t{CatUut.WWAN.driver}");
                Console.WriteLine($"FIRMWARE:\t{CatUut.WWAN.firmware}");
                Console.WriteLine($"MODEM:\t\t{CatUut.WWAN.modem}");
                Console.WriteLine($"UDE:\t\t{CatUut.WWAN.ude}");
                Console.WriteLine($"GNSS:\t\t{CatUut.WWAN.gnss}");
                Console.WriteLine();
            }
            void showWlan()
            {
                Console.WriteLine($"================WLAN================");
                Console.WriteLine();
                Console.WriteLine($"HWID:\t\t{CatUut.WLAN.name}");
                Console.WriteLine($"HWID:\t\t{CatUut.WLAN.hwid}");
                Console.WriteLine($"DRIVER:\t\t{CatUut.WLAN.driver}");
                Console.WriteLine();
            }
            void showLan()
            {
                Console.WriteLine($"================LAN=================");
                Console.WriteLine();
                Console.WriteLine($"HWID:\t\t{CatUut.LAN.name}");
                Console.WriteLine($"HWID:\t\t{CatUut.LAN.hwid}");
                Console.WriteLine($"DRIVER:\t\t{CatUut.LAN.driver}");
                Console.WriteLine();
            }
            void showBt()
            {
                Console.WriteLine($"================BT==================");
                Console.WriteLine();
                Console.WriteLine($"HWID:\t\t{CatUut.BT.name}");
                Console.WriteLine($"HWID:\t\t{CatUut.BT.hwid}");
                Console.WriteLine($"DRIVER:\t\t{CatUut.BT.driver}");
                Console.WriteLine();
            }
            void showNfc()
            {
                Console.WriteLine($"================NFC=================");
                Console.WriteLine();
                Console.WriteLine($"HWID:\t\t{CatUut.NFC.name}");
                Console.WriteLine($"HWID:\t\t{CatUut.NFC.hwid}");
                Console.WriteLine($"DRIVER:\t\t{CatUut.NFC.driver}");
                Console.WriteLine();
            }
            void showRfid()
            {
                Console.WriteLine($"================RFID================");
                Console.WriteLine();
                Console.WriteLine($"HWID:\t\t{CatUut.RFID.name}");
                Console.WriteLine($"HWID:\t\t{CatUut.RFID.hwid}");
                Console.WriteLine($"DRIVER:\t\t{CatUut.RFID.driver}");
                Console.WriteLine();
            }
            #endregion
        }
    }
}
