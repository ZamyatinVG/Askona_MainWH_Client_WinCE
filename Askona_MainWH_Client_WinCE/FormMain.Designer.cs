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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumTB
            // 
            this.SumTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            this.SumTB.Location = new System.Drawing.Point(157, 187);
            this.SumTB.Name = "SumTB";
            this.SumTB.ReadOnly = true;
            this.SumTB.Size = new System.Drawing.Size(158, 25);
            this.SumTB.TabIndex = 14;
            // 
            // SumLabel
            // 
            this.SumLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.SumLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SumLabel.Location = new System.Drawing.Point(112, 187);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(75, 20);
            this.SumLabel.Text = "Итг";
            // 
            // CountTB
            // 
            this.CountTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular);
            this.CountTB.Location = new System.Drawing.Point(48, 187);
            this.CountTB.Name = "CountTB";
            this.CountTB.ReadOnly = true;
            this.CountTB.Size = new System.Drawing.Size(62, 25);
            this.CountTB.TabIndex = 13;
            // 
            // CountLabel
            // 
            this.CountLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.CountLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.CountLabel.Location = new System.Drawing.Point(0, 187);
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
            this.AnswerTB.Size = new System.Drawing.Size(312, 153);
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}