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
        private Symbol.Barcode2.Design.Barcode2 BC2 = new Symbol.Barcode2.Design.Barcode2();
        private Symbol.Notification.Device device;
        private Symbol.Notification.NotifyObject objNotify = null;
        private Symbol.Notification.Beeper beeper = null;

        public FormMain()
        {
            InitializeComponent();
            BC2_Config();
        }

        private void BC2_Config()
        {
            this.BC2.Config.DecoderParameters.CODABAR = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.CODABARParams.ClsiEditing = false;
            this.BC2.Config.DecoderParameters.CODABARParams.NotisEditing = false;
            this.BC2.Config.DecoderParameters.CODABARParams.Redundancy = true;
            this.BC2.Config.DecoderParameters.CODE128 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.CODE128Params.EAN128 = true;
            this.BC2.Config.DecoderParameters.CODE128Params.ISBT128 = true;
            this.BC2.Config.DecoderParameters.CODE128Params.Other128 = true;
            this.BC2.Config.DecoderParameters.CODE128Params.Redundancy = false;
            this.BC2.Config.DecoderParameters.CODE39 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.CODE39Params.Code32Prefix = false;
            this.BC2.Config.DecoderParameters.CODE39Params.Concatenation = false;
            this.BC2.Config.DecoderParameters.CODE39Params.ConvertToCode32 = false;
            this.BC2.Config.DecoderParameters.CODE39Params.FullAscii = false;
            this.BC2.Config.DecoderParameters.CODE39Params.Redundancy = false;
            this.BC2.Config.DecoderParameters.CODE39Params.ReportCheckDigit = false;
            this.BC2.Config.DecoderParameters.CODE39Params.VerifyCheckDigit = false;
            this.BC2.Config.DecoderParameters.CODE93 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.CODE93Params.Redundancy = false;
            this.BC2.Config.DecoderParameters.D2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.D2OF5Params.Redundancy = true;
            this.BC2.Config.DecoderParameters.EAN13 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.EAN8 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.EAN8Params.ConvertToEAN13 = false;
            this.BC2.Config.DecoderParameters.I2OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.I2OF5Params.ConvertToEAN13 = false;
            this.BC2.Config.DecoderParameters.I2OF5Params.Redundancy = true;
            this.BC2.Config.DecoderParameters.I2OF5Params.ReportCheckDigit = false;
            this.BC2.Config.DecoderParameters.I2OF5Params.VerifyCheckDigit = Symbol.Barcode2.Design.I2OF5.CheckDigitSchemes.Default;
            this.BC2.Config.DecoderParameters.KOREAN_3OF5 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.KOREAN_3OF5Params.Redundancy = true;
            this.BC2.Config.DecoderParameters.MSI = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode2.Design.CheckDigitCounts.Default;
            this.BC2.Config.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode2.Design.CheckDigitSchemes.Default;
            this.BC2.Config.DecoderParameters.MSIParams.Redundancy = true;
            this.BC2.Config.DecoderParameters.MSIParams.ReportCheckDigit = false;
            this.BC2.Config.DecoderParameters.UPCA = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode2.Design.Preambles.Default;
            this.BC2.Config.DecoderParameters.UPCAParams.ReportCheckDigit = true;
            this.BC2.Config.DecoderParameters.UPCE0 = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.DecoderParameters.UPCE0Params.ConvertToUPCA = false;
            this.BC2.Config.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode2.Design.Preambles.Default;
            this.BC2.Config.DecoderParameters.UPCE0Params.ReportCheckDigit = false;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Symbol.Barcode2.Design.DPM_MODE.DPM_MODE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Symbol.Barcode2.Design.FOCUS_MODE.FOCUS_MODE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Symbol.Barcode2.Design.FOCUS_POSITION.FOCUS_POSITION_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Symbol.Barcode2.Design.ILLUMINATION_MODE.ILLUMINATION_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Symbol.Barcode2.Design.INVERSE1D_MODE.INVERSE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Symbol.Barcode2.Design.PICKLIST_MODE.PICKLIST_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Symbol.Barcode2.Design.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Symbol.Barcode2.Design.VIEWFINDER_MODE.VIEWFINDER_MODE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0;
            this.BC2.Config.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Symbol.Barcode2.Design.AIM_MODE.AIM_MODE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Symbol.Barcode2.Design.AIM_TYPE.AIM_TYPE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BeamWidth = Symbol.Barcode2.Design.BEAM_WIDTH.DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Symbol.Barcode2.Design.DBP_MODE.DBP_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Symbol.Barcode2.Design.LINEAR_SECURITY_LEVEL.SECURITY_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Symbol.Barcode2.Design.RASTER_MODE.RASTER_MODE_DEFAULT;
            this.BC2.Config.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Symbol.Barcode2.Design.DisabledEnabled.Default;
            this.BC2.Config.ScanDataSize = ((uint)(127u));
            this.BC2.Config.ScanParameters.BeepFrequency = 2000;
            this.BC2.Config.ScanParameters.BeepTime = 100;
            this.BC2.Config.ScanParameters.CodeIdType = Symbol.Barcode2.Design.CodeIdTypes.Default;
            this.BC2.Config.ScanParameters.LedTime = 3000;
            this.BC2.Config.ScanParameters.ScanType = Symbol.Barcode2.Design.SCANTYPES.Default;
            this.BC2.Config.ScanParameters.WaveFile = "";
            this.BC2.DeviceType = Symbol.Barcode2.DEVICETYPES.FIRSTAVAILABLE;
            this.BC2.EnableScanner = true;
            this.BC2.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.BC2_OnScan);
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
            for (int i = 0; i < Symbol.Notification.Device.AvailableDevices.Length; i++)
                if (Symbol.Notification.Device.AvailableDevices[i].ObjectType == Symbol.Notification.NotifyType.BEEPER)
                {
                    device = Symbol.Notification.Device.AvailableDevices[i];
                    if (objNotify != null) objNotify.Dispose();
                    beeper = new Symbol.Notification.Beeper(device);
                    beeper.Duration = 700;
                    beeper.Frequency = 900;
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
                AnswerTB.Text = answer[0].Replace(";", "\r\n");
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