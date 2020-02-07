namespace CatDev
{
    partial class F1_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_expor_json = new System.Windows.Forms.Button();
            this.btn_ref_info = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_wwan_gnss = new System.Windows.Forms.Label();
            this.lb_wwan_ude = new System.Windows.Forms.Label();
            this.lb_wwan_modem = new System.Windows.Forms.Label();
            this.lb_wwan_firmware = new System.Windows.Forms.Label();
            this.lb_rfid_driver = new System.Windows.Forms.Label();
            this.lb_nfc_driver = new System.Windows.Forms.Label();
            this.lb_bt_driver = new System.Windows.Forms.Label();
            this.lb_lan_driver = new System.Windows.Forms.Label();
            this.lb_wlan_driver = new System.Windows.Forms.Label();
            this.lb_wwan_driver = new System.Windows.Forms.Label();
            this.lb_rfid_hwid = new System.Windows.Forms.Label();
            this.lb_nfc_hwid = new System.Windows.Forms.Label();
            this.lb_bt_hwid = new System.Windows.Forms.Label();
            this.lb_lan_hwid = new System.Windows.Forms.Label();
            this.lb_wlan_hwid = new System.Windows.Forms.Label();
            this.lb_wwan_hwid = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_devinfo = new System.Windows.Forms.GroupBox();
            this.lb_platform = new System.Windows.Forms.Label();
            this.lb_image = new System.Windows.Forms.Label();
            this.lb_os = new System.Windows.Forms.Label();
            this.lb_bios = new System.Windows.Forms.Label();
            this.lb_sn = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_appname = new System.Windows.Forms.Label();
            this.btn_appclose = new System.Windows.Forms.Button();
            this.bgw_load_dev = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gp_devinfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 604);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_expor_json);
            this.panel2.Controls.Add(this.btn_ref_info);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gp_devinfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 574);
            this.panel2.TabIndex = 1;
            // 
            // btn_expor_json
            // 
            this.btn_expor_json.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_expor_json.Enabled = false;
            this.btn_expor_json.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expor_json.Location = new System.Drawing.Point(459, 530);
            this.btn_expor_json.Name = "btn_expor_json";
            this.btn_expor_json.Size = new System.Drawing.Size(75, 23);
            this.btn_expor_json.TabIndex = 1;
            this.btn_expor_json.Text = "Export .json";
            this.btn_expor_json.UseVisualStyleBackColor = false;
            this.btn_expor_json.Click += new System.EventHandler(this.btn_expor_json_Click);
            // 
            // btn_ref_info
            // 
            this.btn_ref_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ref_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ref_info.Location = new System.Drawing.Point(378, 530);
            this.btn_ref_info.Name = "btn_ref_info";
            this.btn_ref_info.Size = new System.Drawing.Size(75, 23);
            this.btn_ref_info.TabIndex = 1;
            this.btn_ref_info.Text = "Refresh";
            this.btn_ref_info.UseVisualStyleBackColor = false;
            this.btn_ref_info.Click += new System.EventHandler(this.btn_ref_info_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lb_wwan_gnss);
            this.panel3.Controls.Add(this.lb_wwan_ude);
            this.panel3.Controls.Add(this.lb_wwan_modem);
            this.panel3.Controls.Add(this.lb_wwan_firmware);
            this.panel3.Controls.Add(this.lb_rfid_driver);
            this.panel3.Controls.Add(this.lb_nfc_driver);
            this.panel3.Controls.Add(this.lb_bt_driver);
            this.panel3.Controls.Add(this.lb_lan_driver);
            this.panel3.Controls.Add(this.lb_wlan_driver);
            this.panel3.Controls.Add(this.lb_wwan_driver);
            this.panel3.Controls.Add(this.lb_rfid_hwid);
            this.panel3.Controls.Add(this.lb_nfc_hwid);
            this.panel3.Controls.Add(this.lb_bt_hwid);
            this.panel3.Controls.Add(this.lb_lan_hwid);
            this.panel3.Controls.Add(this.lb_wlan_hwid);
            this.panel3.Controls.Add(this.lb_wwan_hwid);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 324);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "gnss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "modem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "firmware";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(42, 304);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(33, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "driver";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(42, 260);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(33, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "driver";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(42, 220);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "driver";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "driver";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "driver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "driver";
            // 
            // lb_wwan_gnss
            // 
            this.lb_wwan_gnss.AutoSize = true;
            this.lb_wwan_gnss.Location = new System.Drawing.Point(100, 95);
            this.lb_wwan_gnss.Name = "lb_wwan_gnss";
            this.lb_wwan_gnss.Size = new System.Drawing.Size(29, 13);
            this.lb_wwan_gnss.TabIndex = 0;
            this.lb_wwan_gnss.Text = "hwid";
            // 
            // lb_wwan_ude
            // 
            this.lb_wwan_ude.AutoSize = true;
            this.lb_wwan_ude.Location = new System.Drawing.Point(100, 82);
            this.lb_wwan_ude.Name = "lb_wwan_ude";
            this.lb_wwan_ude.Size = new System.Drawing.Size(29, 13);
            this.lb_wwan_ude.TabIndex = 0;
            this.lb_wwan_ude.Text = "hwid";
            // 
            // lb_wwan_modem
            // 
            this.lb_wwan_modem.AutoSize = true;
            this.lb_wwan_modem.Location = new System.Drawing.Point(100, 69);
            this.lb_wwan_modem.Name = "lb_wwan_modem";
            this.lb_wwan_modem.Size = new System.Drawing.Size(29, 13);
            this.lb_wwan_modem.TabIndex = 0;
            this.lb_wwan_modem.Text = "hwid";
            // 
            // lb_wwan_firmware
            // 
            this.lb_wwan_firmware.AutoSize = true;
            this.lb_wwan_firmware.Location = new System.Drawing.Point(100, 56);
            this.lb_wwan_firmware.Name = "lb_wwan_firmware";
            this.lb_wwan_firmware.Size = new System.Drawing.Size(29, 13);
            this.lb_wwan_firmware.TabIndex = 0;
            this.lb_wwan_firmware.Text = "hwid";
            // 
            // lb_rfid_driver
            // 
            this.lb_rfid_driver.AutoSize = true;
            this.lb_rfid_driver.Location = new System.Drawing.Point(100, 304);
            this.lb_rfid_driver.Name = "lb_rfid_driver";
            this.lb_rfid_driver.Size = new System.Drawing.Size(29, 13);
            this.lb_rfid_driver.TabIndex = 0;
            this.lb_rfid_driver.Text = "hwid";
            // 
            // lb_nfc_driver
            // 
            this.lb_nfc_driver.AutoSize = true;
            this.lb_nfc_driver.Location = new System.Drawing.Point(100, 260);
            this.lb_nfc_driver.Name = "lb_nfc_driver";
            this.lb_nfc_driver.Size = new System.Drawing.Size(29, 13);
            this.lb_nfc_driver.TabIndex = 0;
            this.lb_nfc_driver.Text = "hwid";
            // 
            // lb_bt_driver
            // 
            this.lb_bt_driver.AutoSize = true;
            this.lb_bt_driver.Location = new System.Drawing.Point(100, 220);
            this.lb_bt_driver.Name = "lb_bt_driver";
            this.lb_bt_driver.Size = new System.Drawing.Size(29, 13);
            this.lb_bt_driver.TabIndex = 0;
            this.lb_bt_driver.Text = "hwid";
            // 
            // lb_lan_driver
            // 
            this.lb_lan_driver.AutoSize = true;
            this.lb_lan_driver.Location = new System.Drawing.Point(100, 180);
            this.lb_lan_driver.Name = "lb_lan_driver";
            this.lb_lan_driver.Size = new System.Drawing.Size(29, 13);
            this.lb_lan_driver.TabIndex = 0;
            this.lb_lan_driver.Text = "hwid";
            // 
            // lb_wlan_driver
            // 
            this.lb_wlan_driver.AutoSize = true;
            this.lb_wlan_driver.Location = new System.Drawing.Point(100, 140);
            this.lb_wlan_driver.Name = "lb_wlan_driver";
            this.lb_wlan_driver.Size = new System.Drawing.Size(29, 13);
            this.lb_wlan_driver.TabIndex = 0;
            this.lb_wlan_driver.Text = "hwid";
            // 
            // lb_wwan_driver
            // 
            this.lb_wwan_driver.AutoSize = true;
            this.lb_wwan_driver.Location = new System.Drawing.Point(100, 43);
            this.lb_wwan_driver.Name = "lb_wwan_driver";
            this.lb_wwan_driver.Size = new System.Drawing.Size(29, 13);
            this.lb_wwan_driver.TabIndex = 0;
            this.lb_wwan_driver.Text = "hwid";
            // 
            // lb_rfid_hwid
            // 
            this.lb_rfid_hwid.AutoSize = true;
            this.lb_rfid_hwid.Location = new System.Drawing.Point(100, 291);
            this.lb_rfid_hwid.Name = "lb_rfid_hwid";
            this.lb_rfid_hwid.Size = new System.Drawing.Size(29, 13);
            this.lb_rfid_hwid.TabIndex = 0;
            this.lb_rfid_hwid.Text = "hwid";
            // 
            // lb_nfc_hwid
            // 
            this.lb_nfc_hwid.AutoSize = true;
            this.lb_nfc_hwid.Location = new System.Drawing.Point(100, 247);
            this.lb_nfc_hwid.Name = "lb_nfc_hwid";
            this.lb_nfc_hwid.Size = new System.Drawing.Size(29, 13);
            this.lb_nfc_hwid.TabIndex = 0;
            this.lb_nfc_hwid.Text = "hwid";
            // 
            // lb_bt_hwid
            // 
            this.lb_bt_hwid.AutoSize = true;
            this.lb_bt_hwid.Location = new System.Drawing.Point(100, 207);
            this.lb_bt_hwid.Name = "lb_bt_hwid";
            this.lb_bt_hwid.Size = new System.Drawing.Size(29, 13);
            this.lb_bt_hwid.TabIndex = 0;
            this.lb_bt_hwid.Text = "hwid";
            // 
            // lb_lan_hwid
            // 
            this.lb_lan_hwid.AutoSize = true;
            this.lb_lan_hwid.Location = new System.Drawing.Point(100, 167);
            this.lb_lan_hwid.Name = "lb_lan_hwid";
            this.lb_lan_hwid.Size = new System.Drawing.Size(29, 13);
            this.lb_lan_hwid.TabIndex = 0;
            this.lb_lan_hwid.Text = "hwid";
            // 
            // lb_wlan_hwid
            // 
            this.lb_wlan_hwid.AutoSize = true;
            this.lb_wlan_hwid.Location = new System.Drawing.Point(100, 127);
            this.lb_wlan_hwid.Name = "lb_wlan_hwid";
            this.lb_wlan_hwid.Size = new System.Drawing.Size(29, 13);
            this.lb_wlan_hwid.TabIndex = 0;
            this.lb_wlan_hwid.Text = "hwid";
            // 
            // lb_wwan_hwid
            // 
            this.lb_wwan_hwid.AutoSize = true;
            this.lb_wwan_hwid.Location = new System.Drawing.Point(100, 30);
            this.lb_wwan_hwid.Name = "lb_wwan_hwid";
            this.lb_wwan_hwid.Size = new System.Drawing.Size(29, 13);
            this.lb_wwan_hwid.TabIndex = 0;
            this.lb_wwan_hwid.Text = "hwid";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(42, 291);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "hwid";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(42, 247);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "hwid";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "hwid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "hwid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "hwid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "hwid";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 278);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(21, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "rfid";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 234);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "nfc";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "bt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "lan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "wlan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "wwan";
            // 
            // gp_devinfo
            // 
            this.gp_devinfo.Controls.Add(this.lb_platform);
            this.gp_devinfo.Controls.Add(this.lb_image);
            this.gp_devinfo.Controls.Add(this.lb_os);
            this.gp_devinfo.Controls.Add(this.lb_bios);
            this.gp_devinfo.Controls.Add(this.lb_sn);
            this.gp_devinfo.Controls.Add(this.label30);
            this.gp_devinfo.Controls.Add(this.label25);
            this.gp_devinfo.Controls.Add(this.label20);
            this.gp_devinfo.Controls.Add(this.label15);
            this.gp_devinfo.Controls.Add(this.label10);
            this.gp_devinfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gp_devinfo.Location = new System.Drawing.Point(12, 6);
            this.gp_devinfo.Name = "gp_devinfo";
            this.gp_devinfo.Size = new System.Drawing.Size(522, 123);
            this.gp_devinfo.TabIndex = 0;
            this.gp_devinfo.TabStop = false;
            this.gp_devinfo.Text = "HP Information";
            // 
            // lb_platform
            // 
            this.lb_platform.AutoSize = true;
            this.lb_platform.Location = new System.Drawing.Point(56, 96);
            this.lb_platform.Name = "lb_platform";
            this.lb_platform.Size = new System.Drawing.Size(18, 13);
            this.lb_platform.TabIndex = 0;
            this.lb_platform.Text = "sn";
            // 
            // lb_image
            // 
            this.lb_image.AutoSize = true;
            this.lb_image.Location = new System.Drawing.Point(56, 76);
            this.lb_image.Name = "lb_image";
            this.lb_image.Size = new System.Drawing.Size(18, 13);
            this.lb_image.TabIndex = 0;
            this.lb_image.Text = "sn";
            // 
            // lb_os
            // 
            this.lb_os.AutoSize = true;
            this.lb_os.Location = new System.Drawing.Point(56, 56);
            this.lb_os.Name = "lb_os";
            this.lb_os.Size = new System.Drawing.Size(18, 13);
            this.lb_os.TabIndex = 0;
            this.lb_os.Text = "sn";
            // 
            // lb_bios
            // 
            this.lb_bios.AutoSize = true;
            this.lb_bios.Location = new System.Drawing.Point(56, 36);
            this.lb_bios.Name = "lb_bios";
            this.lb_bios.Size = new System.Drawing.Size(18, 13);
            this.lb_bios.TabIndex = 0;
            this.lb_bios.Text = "sn";
            // 
            // lb_sn
            // 
            this.lb_sn.AutoSize = true;
            this.lb_sn.Location = new System.Drawing.Point(56, 16);
            this.lb_sn.Name = "lb_sn";
            this.lb_sn.Size = new System.Drawing.Size(18, 13);
            this.lb_sn.TabIndex = 0;
            this.lb_sn.Text = "sn";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "platform";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 76);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "image";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "os";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "bios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "sn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Controls.Add(this.lb_appname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_appclose, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            // 
            // lb_appname
            // 
            this.lb_appname.AutoSize = true;
            this.lb_appname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_appname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_appname.Location = new System.Drawing.Point(3, 0);
            this.lb_appname.Name = "lb_appname";
            this.lb_appname.Size = new System.Drawing.Size(108, 30);
            this.lb_appname.TabIndex = 0;
            this.lb_appname.Text = "CatDev";
            this.lb_appname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_appname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_appname_MouseDown);
            // 
            // btn_appclose
            // 
            this.btn_appclose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_appclose.FlatAppearance.BorderSize = 0;
            this.btn_appclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appclose.Image = ((System.Drawing.Image)(resources.GetObject("btn_appclose.Image")));
            this.btn_appclose.Location = new System.Drawing.Point(507, 3);
            this.btn_appclose.Name = "btn_appclose";
            this.btn_appclose.Size = new System.Drawing.Size(36, 24);
            this.btn_appclose.TabIndex = 1;
            this.btn_appclose.UseVisualStyleBackColor = true;
            this.btn_appclose.Click += new System.EventHandler(this.btn_appclose_Click);
            // 
            // bgw_load_dev
            // 
            this.bgw_load_dev.WorkerReportsProgress = true;
            // 
            // F1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(546, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F1_Main";
            this.Text = "CatDev";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gp_devinfo.ResumeLayout(false);
            this.gp_devinfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_appname;
        private System.Windows.Forms.Button btn_appclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_wwan_gnss;
        private System.Windows.Forms.Label lb_wwan_ude;
        private System.Windows.Forms.Label lb_wwan_modem;
        private System.Windows.Forms.Label lb_wwan_firmware;
        private System.Windows.Forms.Label lb_rfid_driver;
        private System.Windows.Forms.Label lb_nfc_driver;
        private System.Windows.Forms.Label lb_bt_driver;
        private System.Windows.Forms.Label lb_lan_driver;
        private System.Windows.Forms.Label lb_wlan_driver;
        private System.Windows.Forms.Label lb_wwan_driver;
        private System.Windows.Forms.Label lb_rfid_hwid;
        private System.Windows.Forms.Label lb_nfc_hwid;
        private System.Windows.Forms.Label lb_bt_hwid;
        private System.Windows.Forms.Label lb_lan_hwid;
        private System.Windows.Forms.Label lb_wlan_hwid;
        private System.Windows.Forms.Label lb_wwan_hwid;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_devinfo;
        private System.Windows.Forms.Label lb_platform;
        private System.Windows.Forms.Label lb_image;
        private System.Windows.Forms.Label lb_os;
        private System.Windows.Forms.Label lb_bios;
        private System.Windows.Forms.Label lb_sn;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_expor_json;
        private System.Windows.Forms.Button btn_ref_info;
        private System.ComponentModel.BackgroundWorker bgw_load_dev;
    }
}

