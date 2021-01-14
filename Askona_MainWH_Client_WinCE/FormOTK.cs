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
using Microsoft.Win32;
using System.Runtime.InteropServices;
using Symbol.Barcode2;

namespace Askona_MainWH_Client
{
    public partial class FormOTK : Form
    {
        public FormOTK()
        {
            InitializeComponent();
        }

        private void FormOTK_Load(object sender, EventArgs e)
        {
            Send_Receive("#LOADLOC");
            Send_Receive("#QUERYGROUP");
        }

        private void BC2_OnScan(ScanDataCollection scanDataCollection)
        {
            BarcodeTB.Text = "";
            AnswerTB.Text = "";
            ScanData scanData = scanDataCollection.GetFirst;
            if (scanData.Result == Symbol.Barcode2.Results.SUCCESS)
            {
                BarcodeTB.Text = scanData.Text;
                Send_Receive(scanData.Text);
            }
            else BarcodeTB.Text = "Ошибка считывания";
        }

        private void Send_Receive(string barcode)
        {
            FormMenu fm = (FormMenu)this.Owner;
            try
            {
                TcpClient client = new TcpClient(Z_mXML.ServerIP, Convert.ToInt32(Z_mXML.ServerPort));
                Stream s = client.GetStream();
                StreamReader sr = new StreamReader(s);
                StreamWriter sw = new StreamWriter(s);
                sw.AutoFlush = true;
                Z_TSD_Message ztm = new Z_TSD_Message(Z_mXML.DeviceId, Z_mXML.ActionNumber, barcode);
                sw.WriteLine(ztm.ToString(Z_mXML.Separator));
                string server_answer = sr.ReadLine();
                if (server_answer.StartsWith("#QUERYGROUP"))
                {
                    server_answer = server_answer.Substring(11);
                    FillComboBox(GroupDefCB, server_answer, Z_mXML.Separator);
                    GroupDefCB.SelectedIndex = 0;
                }
                else 
                    if (server_answer.StartsWith("#QUERYLIST"))
                    {
                        server_answer = server_answer.Substring(10);
                        FillComboBox(TypeDefCB, server_answer, Z_mXML.Separator);
                        TypeDefCB.SelectedIndex = 0;
                    }
                    else
                        if (server_answer.StartsWith("#LOADLOC"))
                        {
                            server_answer = server_answer.Substring(8);
                            FillComboBox(LocCB, server_answer, Z_mXML.Separator);
                            LocCB.SelectedIndex = Z_mXML.Location;
                        }
                        else AnswerTB.Text = server_answer;
                
                s.Close();
                client.Close();
            }
            catch
            {
                MessageBox.Show("Потеряна связь с серверным приложением.", "Ошибка");
            }
        }

        private void FormOTK_Closed(object sender, EventArgs e)
        {
            BC2.EnableScanner = false;
        }

        private void GroupDefCB_SelectedValueChanged(object sender, EventArgs e)
        {
            Send_Receive("#QUERYLIST" + GroupDefCB.Text);
        }

        private void TabNoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57 || TabNoTB.Text.Length >= 5))
                e.Handled = true;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            FormMenu fm = (FormMenu)this.Owner;
            if (BarcodeTB.Text != "" && TabNoTB.Text != "")
            {
                Send_Receive("#PRINT" + GroupDefCB.Text + "|" + TypeDefCB.Text + "|" + TabNoTB.Text + "|" +
                             fm.SmenaCB.Text.Substring(0, 1) + "|" + LocCB.Text + "|" + fm.TypeCB.Text + "|" + fm.ControlTabNoTB.Text);
                BarcodeTB.Text = "";
            }
            else
                AnswerTB.Text = "Заполнены не все поля!";
        }

        private void LocCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Z_mXML.Location = LocCB.SelectedIndex;
        }

        private void FillComboBox(ComboBox cb, string buffer, char separator)
        {
            cb.Items.Clear();
            int i_pos;
            while (buffer.Length > 0)
            {
                i_pos = buffer.IndexOf(separator);
                if (i_pos > 0)
                {
                    cb.Items.Add(buffer.Substring(0, i_pos));
                    buffer = buffer.Substring(i_pos + 1);
                }
                else
                {
                    cb.Items.Add(buffer);
                    buffer = string.Empty;
                }
            }
        }
    }
}