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
    public partial class FormMenu : Form
    {
        public const string CONSTBUTTON = "ModeButton";
        private Label SmenaLabel;
        public ComboBox SmenaCB;
        private Label TypeLabel;
        public ComboBox TypeCB;
        private Label ControlTabNoLabel;
        public TextBox ControlTabNoTB;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Z_mXML.path = Path.GetFullPath(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName) + ".xml";
            Z_mXML.LoadXML();
            
            if (Z_mXML.IsOTK)
            {
                this.Text = "(" + Z_mXML.DeviceId + ") Выберите параметры:";
                OTKBuild();
            }
            else
            {
                this.Text = "(" + Z_mXML.DeviceId + ") Выбор действия";
                MenuBuild();
            }
        }

        private void FormMenu_Closed(object sender, EventArgs e)
        {
            if (Z_mXML.IsOTK)
                Z_mXML.SaveXML();
        }

        private void MenuBuild()
        {
            while (ModeTC.TabPages.Count < (int)(Z_mXML.MenuLength / Z_mXML.ItemsOnPage) + 1)
            {
                TabPage  tp = new TabPage();
                tp.BackColor = System.Drawing.Color.LightBlue;
                tp.Name = "tabPage" + (ModeTC.TabPages.Count + 1).ToString();
                tp.Size = new System.Drawing.Size(310, 187);
                tp.Text = "стр. " + (ModeTC.TabPages.Count + 1).ToString() + " ";
                ModeTC.Controls.Add(tp);
            }

            for (int i = 0; i < Z_mXML.MenuLength; i++)
            {
                Button mb = new Button();
                mb.BackColor = System.Drawing.Color.DarkOrange;
                mb.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
                mb.Location = new System.Drawing.Point(5, 3 + (i % Z_mXML.ItemsOnPage) * 26);
                mb.Name = CONSTBUTTON + i.ToString();
                mb.Size = new System.Drawing.Size(300, 24);
                mb.Text = Z_mXML.MenuLst(i, 1).PadRight(16, ' ') + "(" + (i % Z_mXML.ItemsOnPage + 1).ToString() + ")";
                ModeTC.TabPages[(int)(i / Z_mXML.ItemsOnPage)].Controls.Add(mb);
            }
        }

        private void OTKBuild()
        {
            ModeTC.Visible = false;

            SmenaLabel = new Label();
            SmenaLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            SmenaLabel.ForeColor = System.Drawing.Color.DarkGreen;
            SmenaLabel.Location = new System.Drawing.Point(50, 20);
            SmenaLabel.Name = "SmenaLabel";
            SmenaLabel.Size = new System.Drawing.Size(76, 25);
            SmenaLabel.Text = "Смена:";
            this.Controls.Add(SmenaLabel);

            SmenaCB = new ComboBox();
            SmenaCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            SmenaCB.Location = new System.Drawing.Point(131, 20);
            SmenaCB.Name = "SmenaCB";
            SmenaCB.Size = new System.Drawing.Size(150, 26);
            SmenaCB.SelectedIndexChanged += new System.EventHandler(this.SmenaCB_SelectedIndexChanged);
            SmenaCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SmenaCB.Items.Add("1 смена");
            SmenaCB.Items.Add("2 смена");
            SmenaCB.Items.Add("3 смена");
            SmenaCB.SelectedIndex = Z_mXML.Smena;
            this.Controls.Add(SmenaCB);

            TypeLabel = new Label();
            TypeLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            TypeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            TypeLabel.Location = new System.Drawing.Point(17, 70);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new System.Drawing.Size(109, 25);
            TypeLabel.Text = "Контроль:";
            this.Controls.Add(TypeLabel);

            TypeCB = new ComboBox();
            TypeCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            TypeCB.Location = new System.Drawing.Point(131, 70);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new System.Drawing.Size(150, 26);
            TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            TypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeCB.Items.Add("выходной");
            TypeCB.Items.Add("операционный");
            TypeCB.SelectedIndex = Z_mXML.ControlType;
            this.Controls.Add(TypeCB);

            ControlTabNoLabel = new Label();
            ControlTabNoLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            ControlTabNoLabel.ForeColor = System.Drawing.Color.DarkGreen;
            ControlTabNoLabel.Location = new System.Drawing.Point(3, 120);
            ControlTabNoLabel.Name = "ControlTabNoLabel";
            ControlTabNoLabel.Size = new System.Drawing.Size(124, 25);
            ControlTabNoLabel.Text = "Таб. номер:";
            this.Controls.Add(ControlTabNoLabel);

            ControlTabNoTB = new TextBox();
            ControlTabNoTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            ControlTabNoTB.Location = new System.Drawing.Point(131, 120);
            ControlTabNoTB.Name = "ControlTabNoTB";
            ControlTabNoTB.Size = new System.Drawing.Size(150, 26);
            ControlTabNoTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTabNoTB_KeyPress);
            ControlTabNoTB.TextChanged += new EventHandler(ControlTabNoTB_TextChanged);
            ControlTabNoTB.Text = Z_mXML.ControlTabNo.ToString();
            this.Controls.Add(ControlTabNoTB);

            Button OKButton = new Button();
            OKButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            OKButton.Location = new System.Drawing.Point(110, 175);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(100, 75);
            OKButton.Text = "OK";
            OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.Controls.Add(OKButton);
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (keyValue == 125) keyValue = 193;
            if (keyValue == 126) keyValue = 194;
            if (keyValue >= 49 && keyValue <= 57 && !Z_mXML.IsOTK)
            {
                int index = Z_mXML.ItemsOnPage * ModeTC.SelectedIndex + (keyValue - 48) - 1;
                foreach (Control ctrl in ModeTC.TabPages[ModeTC.SelectedIndex].Controls)
                {
                    if (ctrl.Name == CONSTBUTTON + index.ToString())
                    {
                        ctrl.BackColor = Color.DarkGreen;
                        this.Refresh();
                        FormMain fm = new FormMain();
                        Z_mXML.ActionNumber = Convert.ToInt32(Z_mXML.MenuLst(index, 0));
                        fm.Text = Z_mXML.MenuLst(index, 1);
                        Z_mXML.IsInit = Convert.ToBoolean(Z_mXML.MenuLst(index, 2));
                        Z_mXML.IsInputQuantity = Convert.ToBoolean(Z_mXML.MenuLst(index, 3));
                        Z_mXML.IsConfirm = Convert.ToBoolean(Z_mXML.MenuLst(index, 4));
                        fm.Owner = this;
                        fm.Show();
                        ctrl.BackColor = Color.DarkOrange;
                        this.Refresh();
                    }
                }
            }
            switch (keyValue)
            {
                case 8: //Back
                    if (!Z_mXML.IsOTK)
                        this.Close();
                    break;
                case 9: //Tab
                    if (ModeTC.SelectedIndex == ModeTC.TabPages.Count - 1)
                        ModeTC.SelectedIndex = 0;
                    else
                        ModeTC.SelectedIndex++;
                    break;
                case 37: //Left
                    if (ModeTC.SelectedIndex == 0)
                        ModeTC.SelectedIndex = ModeTC.TabPages.Count - 1;
                    else
                        ModeTC.SelectedIndex--;
                    break;
                case 39: //Right
                    if (ModeTC.SelectedIndex == ModeTC.TabPages.Count - 1)
                        ModeTC.SelectedIndex = 0;
                    else
                        ModeTC.SelectedIndex++;
                    break;
                case 48: //KEY0 - настройки
                    if (!Z_mXML.IsOTK)
                    {
                        FormSettings f0 = new FormSettings();
                        f0.Owner = this;
                        f0.Show();
                    }
                    break;
                case 27: //Esc - настройки
                    if (Z_mXML.IsOTK)
                    {
                        FormSettings f0 = new FormSettings();
                        f0.Owner = this;
                        f0.Show();
                    }
                    break;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ControlTabNoTB.Text != "")
            {
                FormOTK fo = new FormOTK();
                fo.Owner = this;
                Z_mXML.ActionNumber = 92;
                fo.ShowDialog();
            }
        }

        private void SmenaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Z_mXML.Smena = SmenaCB.SelectedIndex;
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Z_mXML.ControlType = TypeCB.SelectedIndex;
        }

        private void ControlTabNoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57 || ControlTabNoTB.Text.Length >= 5))
                e.Handled = true;
        }

        private void ControlTabNoTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Z_mXML.ControlTabNo = Convert.ToInt32(ControlTabNoTB.Text);
            }
            catch { }
        }
    }
}