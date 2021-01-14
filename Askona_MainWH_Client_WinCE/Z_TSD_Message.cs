using System;
using System.Collections.Generic;
using System.Text;

namespace Askona_MainWH_Client
{
    class Z_TSD_Message
    {
        private string[] _params;

        public Z_TSD_Message()
        {
            this._params = new string[3];
        }

        public Z_TSD_Message(string device, int action, string message)
        {
            this._params = new string[] { device, action.ToString(), message };
        }

        public string ToString(char separator)
        {
            return string.Join(separator.ToString(), this._params);
        }

        public string this[int index]
        {
            get { return this._params[index]; }
        }

        public static Z_TSD_Message ToParams(string buffer, char separator)
        {
            Z_TSD_Message p = new Z_TSD_Message();
            string buf = buffer;
            int index = 0;
            while (buf.Length > 0 && index < p._params.Length)
            {
                int sep = buf.IndexOf(separator);
                if (sep > 0 && index < p._params.Length - 1)
                {
                    p._params[index] = buf.Substring(0, sep);
                    buf = buf.Substring(sep + 1);
                    index++;
                }
                else
                {
                    p._params[index] = buf;
                    buf = string.Empty;
                }
            }
            return p;
        }
    }
}