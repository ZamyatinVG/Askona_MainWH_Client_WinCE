namespace Askona_MainWH_Client
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumTB = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.BarcodeTB = new System.Windows.Forms.TextBox();
            this.BC2 = new Symbol.Barcode2.Design.Barcode2();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumTB
            // 
            this.SumTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            this.SumTB.Location = new System.Drawing.Point(157, 186);
            this.SumTB.Name = "SumTB";
            this.SumTB.ReadOnly = true;
            this.SumTB.Size = new System.Drawing.Size(158, 25);
            this.SumTB.TabIndex = 14;
            // 
            // SumLabel
            // 
            this.SumLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.SumLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SumLabel.Location = new System.Drawing.Point(112, 186);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(75, 20);
            this.SumLabel.Text = "Итг";
            // 
            // CountTB
            // 
            this.CountTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            this.CountTB.Location = new System.Drawing.Point(48, 186);
            this.CountTB.Name = "CountTB";
            this.CountTB.ReadOnly = true;
            this.CountTB.Size = new System.Drawing.Size(62, 25);
            this.CountTB.TabIndex = 13;
            // 
            // CountLabel
            // 
            this.CountLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.CountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.CountLabel.Location = new System.Drawing.Point(0, 186);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(85, 20);
            this.CountLabel.Text = "Кол";
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.BarcodeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.BarcodeLabel.Location = new System.Drawing.Point(0, 5);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(47, 23);
            this.BarcodeLabel.Text = "Ш/к";
            // 
            // AnswerTB
            // 
            this.AnswerTB.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular);
            this.AnswerTB.Location = new System.Drawing.Point(3, 33);
            this.AnswerTB.Multiline = true;
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.ReadOnly = true;
            this.AnswerTB.Size = new System.Drawing.Size(312, 150);
            this.AnswerTB.TabIndex = 12;
            // 
            // BarcodeTB
            // 
            this.BarcodeTB.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular);
            this.BarcodeTB.Location = new System.Drawing.Point(47, 3);
            this.BarcodeTB.Name = "BarcodeTB";
            this.BarcodeTB.ReadOnly = true;
            this.BarcodeTB.Size = new System.Drawing.Size(268, 28);
            this.BarcodeTB.TabIndex = 11;
            // 
            // BC2
            // 
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
            this.BC2.Config.ScanDataSize = ((uint)(55u));
            this.BC2.Config.ScanParameters.BeepFrequency = 2000;
            this.BC2.Config.ScanParameters.BeepTime = 100;
            this.BC2.Config.ScanParameters.CodeIdType = Symbol.Barcode2.Design.CodeIdTypes.Default;
            this.BC2.Config.ScanParameters.LedTime = 3000;
            this.BC2.Config.ScanParameters.ScanType = Symbol.Barcode2.Design.SCANTYPES.Default;
            this.BC2.Config.ScanParameters.WaveFile = "";
            this.BC2.DeviceType = Symbol.Barcode2.DEVICETYPES.FIRSTAVAILABLE;
            this.BC2.EnableScanner = true;
            this.BC2.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.BC2_OnScan);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.CancelButton.ForeColor = System.Drawing.Color.Brown;
            this.CancelButton.Location = new System.Drawing.Point(198, 87);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 30);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.Visible = false;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.OKButton.ForeColor = System.Drawing.Color.Brown;
            this.OKButton.Location = new System.Drawing.Point(0, 87);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 30);
            this.OKButton.TabIndex = 18;
            this.OKButton.Text = "Подтверд.";
            this.OKButton.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(318, 215);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SumTB);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.CountTB);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.BarcodeTB);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "СКАНИРОВАНИЕ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Closed += new System.EventHandler(this.FormMain_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SumTB;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.TextBox BarcodeTB;
        private Symbol.Barcode2.Design.Barcode2 BC2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}