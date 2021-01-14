namespace Askona_MainWH_Client
{
    partial class FormSettings
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
            this.DeviceIdTB = new System.Windows.Forms.TextBox();
            this.DeviceIdLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.IPTB = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeviceIdTB
            // 
            this.DeviceIdTB.Enabled = false;
            this.DeviceIdTB.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.DeviceIdTB.Location = new System.Drawing.Point(94, 20);
            this.DeviceIdTB.Name = "DeviceIdTB";
            this.DeviceIdTB.Size = new System.Drawing.Size(190, 28);
            this.DeviceIdTB.TabIndex = 8;
            // 
            // DeviceIdLabel
            // 
            this.DeviceIdLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.DeviceIdLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.DeviceIdLabel.Location = new System.Drawing.Point(41, 20);
            this.DeviceIdLabel.Name = "DeviceIdLabel";
            this.DeviceIdLabel.Size = new System.Drawing.Size(50, 30);
            this.DeviceIdLabel.Text = "ID:";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(198, 175);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(120, 40);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.OKButton.Location = new System.Drawing.Point(0, 175);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(120, 40);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            // 
            // PortTB
            // 
            this.PortTB.Enabled = false;
            this.PortTB.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.PortTB.Location = new System.Drawing.Point(94, 122);
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(190, 28);
            this.PortTB.TabIndex = 11;
            // 
            // IPTB
            // 
            this.IPTB.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.IPTB.Location = new System.Drawing.Point(94, 71);
            this.IPTB.Name = "IPTB";
            this.IPTB.Size = new System.Drawing.Size(190, 28);
            this.IPTB.TabIndex = 9;
            // 
            // PortLabel
            // 
            this.PortLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.PortLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.PortLabel.Location = new System.Drawing.Point(13, 122);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(80, 30);
            this.PortLabel.Text = "Порт:";
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.IPLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.IPLabel.Location = new System.Drawing.Point(41, 71);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(50, 30);
            this.IPLabel.Text = "IP:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(318, 215);
            this.Controls.Add(this.DeviceIdTB);
            this.Controls.Add(this.DeviceIdLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PortTB);
            this.Controls.Add(this.IPTB);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "НАСТРОЙКА СОЕДИНЕНИЯ";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DeviceIdTB;
        private System.Windows.Forms.Label DeviceIdLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox PortTB;
        private System.Windows.Forms.TextBox IPTB;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label IPLabel;
    }
}