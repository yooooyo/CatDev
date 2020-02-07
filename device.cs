using MbnApi;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;


namespace CatDev
{

    public class CatUut
    {
        public static string SN
        {
            get
            {
                string sn="NA";
                using(ManagementObjectSearcher m = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS"))
                {
                    foreach(var v in m.Get())
                    {
                        if (v != null)
                        {
                            sn = (v.GetPropertyValue("SerialNumber")).ToString();
                        }
                        
                    }
                }
                return sn;
            }
        }

        public static string Platform
        {
            get
            {
                string platform = "NA";
                using (ManagementObjectSearcher m = new ManagementObjectSearcher("SELECT Name FROM Win32_ComputerSystemProduct"))
                {
                    foreach (var v in m.Get())
                    {
                        if (v != null)
                        {
                            platform = (v.GetPropertyValue("Name")).ToString();
                        }

                    }
                }
                return platform;
            }
        }

        public static string OS
        {
            get
            {
                string os = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", "NA").ToString();
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\HpComm\\CAT\\UUT", "OS", os, RegistryValueKind.String);
                return os;
            }
        }
        public static string Image
        {
            get
            {
                string image = "";
                using (ManagementObjectSearcher m = new ManagementObjectSearcher("SELECT OEMStringArray FROM Win32_COMPUTERSYSTEM"))
                {
                    foreach (var v in m.Get())
                    {
                        foreach (var p in v.Properties)
                        {
                            foreach (var str in (string[])p.Value)
                            {
                                if (str.Contains("BUILDID"))
                                {
                                    try
                                    {
                                        image = str.Split('#')[1];

                                    }
                                    catch
                                    {
                                        Console.WriteLine("BUILD ID MISSING");
                                        image = "";
                                    }
                                }
                            }
                        }
                    }

                }
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\HpComm\\CAT\\UUT", "IMG", image, RegistryValueKind.String);
                return image;
            }
        }
        public static string BIOS
        {
            get
            {
                string bios = Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVersion", "NA").ToString();
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\HpComm\\CAT\\UUT", "BIOS", bios, RegistryValueKind.String);
                return bios;
            }
        }
        public struct WLAN
        {
            public static string hwid = "NA";
            public static string driver = "NA";
        }
        public struct BT
        {
            public static string hwid = "NA";
            public static string driver = "NA";
        }
        public struct WWAN
        {
            public static string hwid = "NA";
            public static string driver = "NA";
            public static string modem = "NA";
            public static string firmware = "NA";
            public static string ude = "NA";
            public static string gnss = "NA";

        }
        public struct LAN
        {
            public static string hwid = "NA";
            public static string driver = "NA";
        }
        public struct RFID
        {
            public static string hwid = "NA";
            public static string driver = "NA";
        }
        public struct NFC
        {
            public static string hwid = "NA";
            public static string driver = "NA";
        }
        public static void GetCommDev()
        {
            string queryStr = CatConvert.deviceQuery(@".\DeviceQuery.json");
            var devs = new List<Dictionary<string, string>>();
            using (ManagementObjectSearcher m = new ManagementObjectSearcher(queryStr))
            {
                foreach (var v in m.Get())
                {
                    var dev = new Dictionary<string, string>();

                    foreach (var p in v.Properties)
                    {
                        dev.Add(p.Name, ((string)p.Value).ToLower());
                        
                        //Console.WriteLine($"Name {p.Name} Value {p.Value}");
                    }

                    devs.Add(dev);
                }
            }
            var wlan = (from dev in devs
                        where (dev["Description"].Contains("intel") && dev["Description"].Contains("wireless")) || (dev["Description"].Contains("intel") && dev["Description"].Contains("wi-fi")) || (dev["Description"].Contains("realtek") && dev["Description"].Contains("802.11"))
                        select dev).FirstOrDefault();
            var lan = (from dev in devs
                       where (dev["Description"].Contains("intel") && dev["Description"].Contains("ethernet")) || (dev["Description"].Contains("realtek") && dev["Description"].Contains("gbe"))
                       select dev).FirstOrDefault();
            var wwan = (from dev in devs
                            where (dev["Description"].Contains("mobile broadband"))
                            select dev).FirstOrDefault();
            var ude = (from dev in devs
                       where (dev["Description"].Contains("intel") && dev["Description"].Contains("xmm")) || (dev["Description"].Contains("hp") && dev["Description"].Contains("lte"))
                       select dev).FirstOrDefault();
            var modem = (from dev in devs
                         where (dev["Description"].Contains("modem"))
                         select dev).FirstOrDefault();
            var gnss = (from dev in devs
                        where (dev["Description"].Contains("gnss"))
                        select dev).FirstOrDefault();
            var bt = (from dev in devs
                         where (dev["Description"].Contains("intel")&& dev["Description"].Contains("bluetooth")) || (dev["Description"].Contains("realtek") && dev["Description"].Contains("bluetooth"))
                      select dev).FirstOrDefault();
            var nfc = (from dev in devs
                      where (dev["Description"].Contains("nfc")) || (dev["Description"].Contains("nxp"))
                      select dev).FirstOrDefault();
            var rfid = (from dev in devs
                        where (dev["HardWareID"].Contains("0C27"))
                        select dev).FirstOrDefault();

            if (wlan != null && wlan.Count > 0)
            {
                CatUut.WLAN.hwid = wlan["HardWareID"];
                CatUut.WLAN.driver = wlan["DriverVersion"];
            }
            if (lan != null && lan.Count > 0)
            {
                CatUut.LAN.hwid = lan["HardWareID"];
                CatUut.LAN.driver = lan["DriverVersion"];
            }
            if (wwan != null && wwan.Count > 0)
            {
                CatUut.WWAN.hwid = wwan["HardWareID"];
            }
            if (ude != null && ude.Count > 0)
            {
                CatUut.WWAN.ude = ude["DriverVersion"];
            }
            if (modem != null && modem.Count > 0)
            {
                CatUut.WWAN.modem = modem["DriverVersion"];
            }
            if (gnss != null && gnss.Count > 0)
            {
                CatUut.WWAN.gnss = gnss["DriverVersion"];
            }
            CatUut.WWAN.firmware = GetWWANFW();
            CatUut.WWAN.driver   = GetWWANDR();
            if (bt != null && bt.Count > 0)
            {
                CatUut.BT.hwid = bt["HardWareID"];
                CatUut.BT.driver = bt["DriverVersion"];
            }
            if (nfc != null && nfc.Count > 0)
            {
                CatUut.NFC.hwid = nfc["HardWareID"];
                CatUut.NFC.driver = nfc["DriverVersion"];
            }
            if (rfid != null && rfid.Count > 0)
            {
                CatUut.RFID.hwid = rfid["HardWareID"];
                CatUut.RFID.driver = rfid["DriverVersion"];
            }

        }
        public static void GetCommDevConvertJson()
        {
            GetCommDev();
            deviceJson dev = new deviceJson()
            {
                sn = CatUut.SN,
                bios = CatUut.BIOS,
                os = CatUut.OS,
                image = CatUut.Image,
                platform = CatUut.Platform,
                wwan = new List<Wwan>()
                {
                    new Wwan()
                    {
                        hwid =CatUut.WWAN.hwid,
                        driver =CatUut.WWAN.driver,
                        modem =CatUut.WWAN.modem,
                        firmware =CatUut.WWAN.firmware,
                        ude =CatUut.WWAN.ude,
                        gnss =CatUut.WWAN.gnss,
                    }
                },
                wlan = new List<Wlan>()
                {
                    new Wlan()
                    {
                        hwid =CatUut.WLAN.hwid,
                        driver =CatUut.WLAN.driver,
                    }
                },
                lan = new List<Lan>()
                {
                    new Lan()
                    {
                        hwid =CatUut.LAN.hwid,
                        driver =CatUut.LAN.driver,
                    }
                },
                bt = new List<Bt>()
                {
                    new Bt()
                    {
                        hwid =CatUut.BT.hwid,
                        driver =CatUut.BT.driver,
                    }
                },
                nfc = new List<Nfc>()
                {
                    new Nfc()
                    {
                        hwid =CatUut.NFC.hwid,
                        driver =CatUut.NFC.driver,
                    }
                },
                rfid = new List<Rfid>()
                {
                    new Rfid()
                    {
                        hwid =CatUut.RFID.hwid,
                        driver =CatUut.RFID.driver,
                    }
                },

            };
            CatConvert.deviceToJson(dev, $@"{Path.Combine(AppDomain.CurrentDomain.BaseDirectory)}CatDevOut.json");
        }

        private static string GetWWANFW()
        {
            MbnInterfaceManager mbn = new MbnInterfaceManager();
            IMbnInterfaceManager imbn = (IMbnInterfaceManager)mbn;

            IMbnInterface[] interfaces = (IMbnInterface[])imbn.GetInterfaces();
            void debug()
            {
                foreach (var _interface in interfaces)
                {
                    MBN_INTERFACE_CAPS caps = _interface.GetInterfaceCapability();
                    MBN_PROVIDER provider = _interface.GetHomeProvider();
                    MBN_READY_STATE readyState = _interface.GetReadyState();
                    IMbnRadio radio = (IMbnRadio)_interface;

                    Console.WriteLine();
                    Console.WriteLine("Manufacturer:        " + caps.manufacturer);
                    Console.WriteLine("Model:               " + caps.model);
                    Console.WriteLine("DeviceID:            " + caps.deviceID);
                    Console.WriteLine("FirmwareInfo:        " + caps.firmwareInfo);
                    Console.WriteLine("Ready State :        " + readyState.ToString());
                    Console.WriteLine("HardwareRadioState:  " + radio.HardwareRadioState.ToString());
                    Console.WriteLine("SoftwareRadioState:  " + radio.SoftwareRadioState.ToString());
                    Console.WriteLine("InterfaceID:         " + _interface.InterfaceID);
                    Console.WriteLine("Provider:            " + provider.providerName);
                    Console.WriteLine("ProviderID:          " + provider.providerID);
                    Console.WriteLine("ProviderState:       " + provider.providerState);

                }
            }
            try
            {
                //x64
                //string output = "";
                //if (executeProgram(@"netsh ", "mbn sh inter", out output) && output != "")
                //{//Firmware Version
                //    foreach (string line in output.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                //    {
                //        if (line.Contains("Firmware")) { CatUut.WWAN.firmware = line.Substring(line.IndexOf(":") + ":".Length).Trim(); break; }
                //    }
                //}

                //x86
                foreach (var _interface in interfaces)
                {
                    MBN_INTERFACE_CAPS caps = _interface.GetInterfaceCapability();
                    return caps.firmwareInfo.Trim();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            return "NA";
        }
        private static string GetWWANDR()
        {
            try
            {
                string registry_key = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
                using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                        {
                            if (subkey.GetValue("DisplayName") != null && subkey.GetValue("DisplayName").ToString().Contains("XMM")) return subkey.GetValue("DisplayVersion").ToString();
                        }
                    }
                }
            }
            catch(Exception e)
            {

            }
            return "NA";
        }
        private static bool executeProgram(string exePath, string exeCommand, out string Output)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = exePath;
                process.StartInfo.Arguments = exeCommand;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                StreamReader reader = process.StandardOutput;
                Output = reader.ReadToEnd();
                process.WaitForExit();
                return true;

            }
            catch
            {
                Output = "";
                return false;
            }

        }

    }


}
