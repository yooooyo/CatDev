using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CatDev
{
    #region Device
    public class Wwan
    {
        public string name { get; set; }
        public string hwid { get; set; }
        public string driver { get; set; }
        public string modem { get; set; }
        public string firmware { get; set; }
        public string ude { get; set; }
        public string gnss { get; set; }
    }

    public class Wlan
    {
        public string name { get; set; }
        public string hwid { get; set; }
        public string driver { get; set; }
    }

    public class Lan
    {
        public string name { get; set; }
        public string hwid { get; set; }
        public string driver { get; set; }
    }

    public class Bt
    {
        public string name { get; set; }
        public string hwid { get; set; }
        public string driver { get; set; }
    }


    public class Nfc
    {
        public string name { get; set; }
        public string hwid { get; set; }
        public string driver { get; set; }
    }

    public class Rfid
    {
        public string name { get; set; }
        public string hwid { get; set; }
        public string driver { get; set; }
    }

    public class deviceJson
    {
        public string sn { get; set; }
        public string bios { get; set; }
        public string os { get; set; }
        public string image { get; set; }
        public string platform { get; set; }
        public List<Wwan> wwan { get; set; }
        public List<Wlan> wlan { get; set; }
        public List<Lan> lan { get; set; }
        public List<Bt> bt { get; set; }
        public List<Nfc> nfc { get; set; }
        public List<Rfid> rfid { get; set; }
        public string stamp { get; set; }
    }

    #endregion

    public class CatConvert
    {
        public static deviceJson deviceToClass(string path)
        {
            deviceJson jsnObj = null;
            if (File.Exists(path)&&path.Contains(".json"))
            {
                StreamReader srd = new StreamReader(path);
                var deSer = srd.ReadToEnd();
                jsnObj = JsonConvert.DeserializeObject<deviceJson>(deSer);
            }
            else
            {
                Console.WriteLine("Can't find file or file error");
            }
            return jsnObj;
        }

        public static void deviceToJson(deviceJson devicejson, string path_save)
        {
            using (StreamWriter sw = new StreamWriter(path_save, false))
            {
                devicejson.stamp = DateTime.Now.ToString("O");
                var content = JsonConvert.SerializeObject(devicejson);
                sw.WriteLine(content);
                Console.WriteLine($"Output to {path_save}");
                sw.Close();
            }
        }

        public static string deviceQuery(string path)
        {
            string deSer = "";
            if (File.Exists(path) && path.Contains(".json"))
            {
                StreamReader srd = new StreamReader(path);
                Array a = Array.CreateInstance(typeof(String), 10);
                var rd = srd.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var ls = rd.ToList();
                deSer = string.Join(" or ", ls.GetRange(1, ls.Count - 1));
                deSer = rd[0] + deSer;
            }
            else
            {
                Console.WriteLine("Can't find file or file error");
            }
            return deSer;
        }
    }




}
