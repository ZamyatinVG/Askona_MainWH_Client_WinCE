using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;

namespace Askona_MainWH_Client
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            DeviceIdTB.Text = Z_mXML.DeviceId;
            IPTB.Text = Z_mXML.ServerIP;
            PortTB.Text = Z_mXML.ServerPort.ToString();
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            FormMenu fs = (FormMenu)this.Owner;
            int keyValue = e.KeyValue;
            if (keyValue == 125) keyValue = 193;
            if (keyValue == 126) keyValue = 194;
            switch (keyValue)
            {
                case (char)193:
                    Z_mXML.DeviceId = DeviceIdTB.Text;
                    Z_mXML.ServerIP = IPTB.Text;
                    Z_mXML.ServerPort = PortTB.Text;
                    Z_mXML.SaveXML();
                    if (Z_mXML.IsOTK)
                        fs.Text = "(" + Z_mXML.DeviceId + ") Выберите параметры:";
                    else
                        fs.Text = "(" + DeviceIdTB.Text + ") Выбор действия";
                    this.Close();
                    break;
                case (char)194:
                    this.Close();
                    break;
            }
        }
    }
}