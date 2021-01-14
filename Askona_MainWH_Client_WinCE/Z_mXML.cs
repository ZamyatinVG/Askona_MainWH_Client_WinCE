using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

static class Z_mXML
{
    public static string path;
    private static string[,] MENU_LST;
    private static string[,] ACTION_LST;
    private static string[,] BUTTON_LST;

    static Z_mXML()
    {
        MENU_LST = new string[100, 5];
        ACTION_LST = new string[100, 4];
        BUTTON_LST = new string[100, 3];
    }

    public static int MenuLength { get; private set; }

    public static int ActionLength { get; private set; }

    public static int ButtonLength { get; private set; }

    public static string MenuLst(int xindex, int yindex) { return MENU_LST[xindex, yindex]; }

    public static string ActionLst(int xindex, int yindex) { return ACTION_LST[xindex, yindex]; }

    public static string ButtonList(int xindex, int yindex) { return BUTTON_LST[xindex, yindex]; }

    public static void LoadXML()
    {
        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(path);
            foreach (XmlNode add in xmlDoc.GetElementsByTagName("add"))
            {
                if (add.Attributes["key"].Value == "DEVICE_ID") DeviceId = Convert.ToString(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "IP") ServerIP = Convert.ToString(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "PORT") ServerPort = add.Attributes["value"].Value;
                if (add.Attributes["key"].Value == "ITEMSONPAGE") ItemsOnPage = Convert.ToInt32(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "SEPARATOR") Separator = Convert.ToChar(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "OTK") IsOTK = Convert.ToBoolean(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "SMENA") Smena = Convert.ToInt32(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "LOCATION") Location = Convert.ToInt32(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "CONTROL_TYPE") ControlType = Convert.ToInt32(add.Attributes["value"].Value);
                if (add.Attributes["key"].Value == "CONTROL_TABNO") ControlTabNo = Convert.ToInt32(add.Attributes["value"].Value);
            }
            MenuLength = 0;
            foreach (XmlNode menu in xmlDoc.GetElementsByTagName("menu"))
            {
                MENU_LST[MenuLength, 0] = menu.Attributes["mod"].Value.ToString();
                MENU_LST[MenuLength, 1] = menu.Attributes["value"].Value.ToString();
                MENU_LST[MenuLength, 2] = menu.Attributes["init"].Value.ToString();
                MENU_LST[MenuLength, 3] = menu.Attributes["input_quantity"].Value.ToString();
                MENU_LST[MenuLength, 4] = menu.Attributes["confirm"].Value.ToString();
                MenuLength++;
            }
            ActionLength = 0;
            foreach (XmlNode action in xmlDoc.GetElementsByTagName("action"))
            {
                ACTION_LST[ActionLength, 0] = action.Attributes["mod"].Value.ToString();
                ACTION_LST[ActionLength, 1] = action.Attributes["key"].Value.ToString();
                ACTION_LST[ActionLength, 2] = action.Attributes["command"].Value.ToString();
                ACTION_LST[ActionLength, 3] = action.Attributes["message"].Value.ToString();
                ActionLength++;
            }
            ButtonLength = 0;
            foreach (XmlNode button in xmlDoc.GetElementsByTagName("button"))
            {
                BUTTON_LST[ButtonLength, 0] = button.Attributes["mod"].Value.ToString();
                BUTTON_LST[ButtonLength, 1] = button.Attributes["command"].Value.ToString();
                BUTTON_LST[ButtonLength, 2] = button.Attributes["message"].Value.ToString();
                ButtonLength++;
            }
        }
        catch (Exception exp)
        {
            MessageBox.Show("Отсутствует файл настроек или неверные настройки!\n\n" + exp, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
    }

    private static void AddXmlTW(XmlTextWriter TW, string type, string key, string value)
    {
        TW.WriteStartElement(type);
        TW.WriteAttributeString("key", key);
        TW.WriteAttributeString("value", value);
        TW.WriteEndElement();
    }

    public static void SaveXML()
    {
        XmlDocument xmlDoc = new XmlDocument();
        try
        {
            xmlDoc.Load(path);
            foreach (XmlNode add in xmlDoc.GetElementsByTagName("add"))
            {
                if (add.Attributes["key"].Value == "DEVICE_ID") add.Attributes["value"].Value = DeviceId;
                if (add.Attributes["key"].Value == "IP") add.Attributes["value"].Value = ServerIP;
                if (add.Attributes["key"].Value == "PORT") add.Attributes["value"].Value = ServerPort;
                if (add.Attributes["key"].Value == "SMENA") add.Attributes["value"].Value = Smena.ToString();
                if (add.Attributes["key"].Value == "LOCATION") add.Attributes["value"].Value = Location.ToString();
                if (add.Attributes["key"].Value == "CONTROL_TYPE") add.Attributes["value"].Value = ControlType.ToString();
                if (add.Attributes["key"].Value == "CONTROL_TABNO") add.Attributes["value"].Value = ControlTabNo.ToString();
            }
            xmlDoc.Save(path);
        }
        catch (Exception exp)
        {
            MessageBox.Show("Отсутствует файл настроек или неверные настройки!\n\n" + exp, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
    }

    public static string DeviceId { get; set; }

    public static string ServerIP { get; set; }

    public static string ServerPort { get; set; }

    public static int ActionNumber { get; set; }

    public static bool IsInit { get; set; }

    public static int ItemsOnPage { get; private set; }

    public static char Separator { get; private set; }
    
    public static bool IsInputQuantity { get; set; }

    public static bool IsConfirm { get; set; }

    public static bool IsOTK { get; set; }

    public static int Smena { get; set; }

    public static int Location { get; set; }

    public static int ControlType { get; set; }

    public static int ControlTabNo { get; set; }
}