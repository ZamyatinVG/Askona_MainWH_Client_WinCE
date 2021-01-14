using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Symbol;
using Symbol.Barcode2;
using Symbol.Notification;
using System.Runtime;

namespace Askona_MainWH_Client
{
    public partial class FormMain : Form
    {
        private Symbol.Notification.Device device;
        private Symbol.Notification.NotifyObject objNotify = null;
        private Symbol.Notification.Beeper beeper = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            if (Z_mXML.IsConfirm)
            {
                OKButton.Top = CancelButton.Top = this.Height - 59;
                if (this.Height < 294)
                {
                    AnswerTB.Height -= 30;
                    CountLabel.Top = CountTB.Top = SumLabel.Top = SumTB.Top -= 30;
                }
            }
            ButtonBuild();
            //init beeper
            for (int i = 0; i < Symbol.Notification.Device.AvailableDevices.Length; i++)
                if (Symbol.Notification.Device.AvailableDevices[i].ObjectType == Symbol.Notification.NotifyType.BEEPER)
                {
                    device = Symbol.Notification.Device.AvailableDevices[i];
                    if (objNotify != null) objNotify.Dispose();
                    beeper = new Symbol.Notification.Beeper(device);
                    beeper.Duration = 700;
                    beeper.Frequency = 900;
                    //beeper.Volume = 3;
                    objNotify = beeper;
                }

            if (Z_mXML.IsInit)
            {
                BarcodeTB.Text = "Соединение...";
                Send_Receive("#SOPRCOUNTER");
            }
        }

        private void FormMain_Closed(object sender, EventArgs e)
        {
            if (beeper != null) beeper.Dispose();
            BC2.EnableScanner = false;
        }

        private void BC2_OnScan(ScanDataCollection scanDataCollection)
        {
            try
            {
                BarcodeTB.Text = "";
                AnswerTB.Text = "";
                ScanData scanData = scanDataCollection.GetFirst;
                if (scanData.Result == Symbol.Barcode2.Results.SUCCESS)
                {
                    BarcodeTB.Text = scanData.Text;
                    if (Z_mXML.IsInputQuantity && BarcodeTB.Text.StartsWith("8001") && (BarcodeTB.Text.Length == 16 || BarcodeTB.Text.IndexOf('#') == 16))
                    {
                        CountTB.ReadOnly = false;
                        if (BarcodeTB.Text.IndexOf('#') == 16)
                            CountTB.Text = BarcodeTB.Text.Substring(17);
                        else CountTB.Text = "1";
                        CountTB.Focus();
                    }
                    else
                        Send_Receive(scanData.Text);
                }
                else BarcodeTB.Text = "Ошибка";
            }
            catch { }
        }

        private void Send_Receive(string barcode)
        {
            try
            {
                IPEndPoint localEP = new IPEndPoint(IPAddress.Parse(Z_mXML.ServerIP), Convert.ToInt32(Z_mXML.ServerPort));
                TcpClient client = new TcpClient();
                client.Connect(localEP);
                Stream s = client.GetStream();
                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                sw.AutoFlush = true;
                Z_TSD_Message ztm = new Z_TSD_Message(Z_mXML.DeviceId, Z_mXML.ActionNumber, barcode);
                sw.WriteLine(ztm.ToString(Z_mXML.Separator));
                string server_answer = sr.ReadLine();
                Z_TSD_Message answer = Z_TSD_Message.ToParams(server_answer, '|');
                AnswerTB.Text = answer[0];
                CountTB.Text = answer[1];
                SumTB.Text = answer[2];
                
                if (server_answer.IndexOf('!') != -1 && objNotify != null)
                {
                    objNotify.State = Symbol.Notification.NotifyState.ON;
                    System.Threading.Thread.Sleep(300);
                    objNotify.State = Symbol.Notification.NotifyState.OFF;
                    System.Threading.Thread.Sleep(200);
                    objNotify.State = Symbol.Notification.NotifyState.ON;
                    System.Threading.Thread.Sleep(300);
                    objNotify.State = Symbol.Notification.NotifyState.OFF;
                }
                s.Close();
                client.Close();
            }
            catch
            {
                MessageBox.Show("Потеряна связь с серверным приложением.", "Ошибка");
            }
        }

        private void ButtonBuild()
        {
            int j = 0;
            for (int i = 0; i < Z_mXML.ButtonLength; i++)
            {
                if (Z_mXML.ButtonList(i, 0) == Z_mXML.ActionNumber.ToString())
                {
                    Button b = new Button();
                    b.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                    b.Location = new Point(12 * (j + 1) + 90 * j, 220);
                    b.Name = "Button" + i.ToString();
                    b.Size = new Size(90, 40);
                    b.Text = Z_mXML.ButtonList(i, 2);
                    b.Click +=new EventHandler(b_Click);
                    this.Controls.Add(b);
                    j++;
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string cmd = Z_mXML.ButtonList(Convert.ToInt32(b.Name.Substring(6)), 1);
            AnswerTB.Text = "";
            BarcodeTB.Text = cmd;
            Send_Receive(cmd);
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (keyValue == 125) keyValue = 193;
            if (keyValue == 126) keyValue = 194;
            switch (keyValue)
            {
                case 8:
                    this.Close();
                    BC2.EnableScanner = false;
                    break;
                case 194:
                    if (!OKButton.Visible || !Z_mXML.IsConfirm)
                    {
                        AnswerTB.Text = "";
                        BarcodeTB.Text = "Сброс операции...";
                        Send_Receive("#KEYTOPRIGHT");
                    }
                    else
                    {
                        BarcodeTB.Text = "";
                        AnswerTB.Text = "";
                        OKButton.Visible = !OKButton.Visible;
                        CancelButton.Visible = !CancelButton.Visible;
                    }
                    break;
            }
            for (int i=0; i < Z_mXML.ActionLength; i++)
                if (Convert.ToInt32(Z_mXML.ActionLst(i, 0)) == Z_mXML.ActionNumber && Convert.ToInt32(Z_mXML.ActionLst(i, 1)) == keyValue)
                {
                    switch (keyValue)
                    {
                        case 193:
                            if (Z_mXML.IsConfirm)
                                if (!OKButton.Visible)
                                {
                                    OKButton.Visible = CancelButton.Visible = true;
                                    BarcodeTB.Text = "";
                                    AnswerTB.Text = "Для подтверждения занесения данных нажмите \"Подтвердить\"";
                                }
                                else
                                {
                                    OKButton.Visible = CancelButton.Visible = false;
                                    goto default;
                                }
                            else
                                goto default;
                            break;
                        default:
                            AnswerTB.Text = "";
                            BarcodeTB.Text = Z_mXML.ActionLst(i, 3);
                            Send_Receive(Z_mXML.ActionLst(i, 2));
                            break;
                    }
                }
            if (Z_mXML.IsInputQuantity)
                switch (keyValue)
                {
                    case 13:
                        if (CountTB.Text.Length != 0)
                        {
                            Send_Receive(BarcodeTB.Text.Substring(0, 16) + "#" + CountTB.Text);
                            CountTB.Text = "";
                            CountTB.ReadOnly = true;
                        }
                        break;
                    case 40:
                        CountTB.Text = "";
                        break;
                }
        }
    }
}