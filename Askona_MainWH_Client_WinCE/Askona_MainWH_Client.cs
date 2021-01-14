using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Askona_MainWH_Client
{
    static class Askona_MainWH_Client
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new FormMenu());
        }
    }
}