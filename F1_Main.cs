using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatDev
{
    public partial class F1_Main : Form
    {
        public F1_Main()
        {
            InitializeComponent();
            ui_load_info();
        }

        private void btn_appclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ui_load_info()
        {
            CatUut.GetCommDev();
            lb_sn.Text = CatUut.SN;
            lb_bios.Text = CatUut.BIOS;
            lb_os.Text = CatUut.OS;
            lb_image.Text = CatUut.Image;
            lb_platform.Text = CatUut.Platform;

            lb_wwan_hwid.Text = CatUut.WWAN.hwid;
            lb_wwan_driver.Text = CatUut.WWAN.driver;
            lb_wwan_firmware.Text = CatUut.WWAN.firmware;
            lb_wwan_modem.Text = CatUut.WWAN.modem;
            lb_wwan_ude.Text = CatUut.WWAN.ude;
            lb_wwan_gnss.Text = CatUut.WWAN.gnss;

            lb_wlan_hwid.Text = CatUut.WLAN.hwid;
            lb_wlan_driver.Text = CatUut.WLAN.driver;

            lb_lan_driver.Text = CatUut.LAN.driver;
            lb_lan_hwid.Text = CatUut.LAN.hwid;

            lb_bt_driver.Text = CatUut.BT.driver;
            lb_bt_hwid.Text = CatUut.BT.hwid;

            lb_nfc_hwid.Text = CatUut.NFC.hwid;
            lb_nfc_driver.Text = CatUut.NFC.driver;

            lb_rfid_hwid.Text = CatUut.RFID.hwid;
            lb_rfid_driver.Text = CatUut.RFID.driver;

        }

        private void btn_ref_info_Click(object sender, EventArgs e)
        {
            btn_expor_json.Enabled = false;
            ui_load_info();
            btn_expor_json.Enabled = true;
        }

        private void btn_expor_json_Click(object sender, EventArgs e)
        {
            btn_ref_info.Enabled = false;
            CatUut.GetCommDevConvertJson();
            btn_ref_info.Enabled = true; ;
        }

        
        private string search_CatDevOut()
        {
            var files = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "CatDevOut.json");
            if (files.Count() > 0) return files[0];
            else return "";
        }

        #region mouse move window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mouse_move_window(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_move_window(e);
        }
        private void lb_appname_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_move_window(e);
        }
        #endregion


    }
}
