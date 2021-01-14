namespace Askona_MainWH_Client
{
    partial class FormOTK
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
            this.BC2 = new Symbol.Barcode2.Design.Barcode2();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.BarcodeTB = new System.Windows.Forms.TextBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.GroupDefCB = new System.Windows.Forms.ComboBox();
            this.TypeDefCB = new System.Windows.Forms.ComboBox();
            this.TabNoLabel = new System.Windows.Forms.Label();
            this.TabNoTB = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LocCB = new System.Windows.Forms.ComboBox();
            this.LocLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.BC2.Config.ScanParameters.BeepFrequency = 200;
            this.BC2.Config.ScanParameters.BeepTime = 100;
            this.BC2.Config.ScanParameters.CodeIdType = Symbol.Barcode2.Design.CodeIdTypes.Default;
            this.BC2.Config.ScanParameters.LedTime = 3000;
            this.BC2.Config.ScanParameters.ScanType = Symbol.Barcode2.Design.SCANTYPES.Default;
            this.BC2.Config.ScanParameters.WaveFile = "";
            this.BC2.DeviceType = Symbol.Barcode2.DEVICETYPES.FIRSTAVAILABLE;
            this.BC2.EnableScanner = true;
            this.BC2.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler(this.BC2_OnScan);
            // 
            // AnswerTB
            // 
            this.AnswerTB.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.AnswerTB.Location = new System.Drawing.Point(3, 28);
            this.AnswerTB.Multiline = true;
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.ReadOnly = true;
            this.AnswerTB.Size = new System.Drawing.Size(312, 60);
            this.AnswerTB.TabIndex = 14;
            // 
            // BarcodeTB
            // 
            this.BarcodeTB.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.BarcodeTB.Location = new System.Drawing.Point(3, 3);
            this.BarcodeTB.Name = "BarcodeTB";
            this.BarcodeTB.Size = new System.Drawing.Size(312, 24);
            this.BarcodeTB.TabIndex = 13;
            // 
            // GroupLabel
            // 
            this.GroupLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.GroupLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.GroupLabel.Location = new System.Drawing.Point(79, 88);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(162, 20);
            this.GroupLabel.Text = "Выбор дефекта:";
            // 
            // GroupDefCB
            // 
            this.GroupDefCB.Location = new System.Drawing.Point(3, 109);
            this.GroupDefCB.Name = "GroupDefCB";
            this.GroupDefCB.Size = new System.Drawing.Size(312, 23);
            this.GroupDefCB.TabIndex = 22;
            this.GroupDefCB.SelectedValueChanged += new System.EventHandler(this.GroupDefCB_SelectedValueChanged);
            // 
            // TypeDefCB
            // 
            this.TypeDefCB.Location = new System.Drawing.Point(3, 133);
            this.TypeDefCB.Name = "TypeDefCB";
            this.TypeDefCB.Size = new System.Drawing.Size(312, 23);
            this.TypeDefCB.TabIndex = 24;
            // 
            // TabNoLabel
            // 
            this.TabNoLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.TabNoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TabNoLabel.Location = new System.Drawing.Point(0, 187);
            this.TabNoLabel.Name = "TabNoLabel";
            this.TabNoLabel.Size = new System.Drawing.Size(113, 20);
            this.TabNoLabel.Text = "таб. номер:";
            // 
            // TabNoTB
            // 
            this.TabNoTB.Location = new System.Drawing.Point(110, 187);
            this.TabNoTB.Name = "TabNoTB";
            this.TabNoTB.Size = new System.Drawing.Size(205, 23);
            this.TabNoTB.TabIndex = 29;
            this.TabNoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TabNoTB_KeyPress);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.PrintButton.Location = new System.Drawing.Point(60, 229);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(200, 40);
            this.PrintButton.TabIndex = 34;
            this.PrintButton.Text = "Печать паспорта";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LocCB
            // 
            this.LocCB.Location = new System.Drawing.Point(110, 158);
            this.LocCB.Name = "LocCB";
            this.LocCB.Size = new System.Drawing.Size(205, 23);
            this.LocCB.TabIndex = 39;
            this.LocCB.SelectedIndexChanged += new System.EventHandler(this.LocCB_SelectedIndexChanged);
            // 
            // LocLabel
            // 
            this.LocLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.LocLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.LocLabel.Location = new System.Drawing.Point(19, 156);
            this.LocLabel.Name = "LocLabel";
            this.LocLabel.Size = new System.Drawing.Size(94, 25);
            this.LocLabel.Text = "участок:";
            // 
            // FormOTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 269);
            this.Controls.Add(this.LocCB);
            this.Controls.Add(this.LocLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TabNoTB);
            this.Controls.Add(this.TabNoLabel);
            this.Controls.Add(this.TypeDefCB);
            this.Controls.Add(this.GroupDefCB);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.BarcodeTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOTK";
            this.Text = "СКАНИРОВАНИЕ";
            this.Load += new System.EventHandler(this.FormOTK_Load);
            this.Closed += new System.EventHandler(this.FormOTK_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private Symbol.Barcode2.Design.Barcode2 BC2;
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.TextBox BarcodeTB;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.ComboBox GroupDefCB;
        private System.Windows.Forms.ComboBox TypeDefCB;
        private System.Windows.Forms.Label TabNoLabel;
        private System.Windows.Forms.TextBox TabNoTB;
        private System.Windows.Forms.Button PrintButton;
        public System.Windows.Forms.ComboBox LocCB;
        private System.Windows.Forms.Label LocLabel;
    }
}