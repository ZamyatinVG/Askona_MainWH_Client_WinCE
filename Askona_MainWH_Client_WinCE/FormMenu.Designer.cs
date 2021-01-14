namespace Askona_MainWH_Client
{
    partial class FormMenu
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
            this.ModeTC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ModeTC.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeTC
            // 
            this.ModeTC.Controls.Add(this.tabPage1);
            this.ModeTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModeTC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.ModeTC.Location = new System.Drawing.Point(0, 0);
            this.ModeTC.Name = "ModeTC";
            this.ModeTC.SelectedIndex = 0;
            this.ModeTC.Size = new System.Drawing.Size(318, 215);
            this.ModeTC.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(310, 187);
            this.tabPage1.Text = "стр. 1 ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(318, 215);
            this.Controls.Add(this.ModeTC);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Выбор действия";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Closed += new System.EventHandler(this.FormMenu_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            this.ModeTC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ModeTC;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

