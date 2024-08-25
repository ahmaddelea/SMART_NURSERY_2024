using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using SMART_NUSERY_FORMS_2024.FORMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SMART_NUSERY_FORMS_2024
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN_DATA_FRM());
        }
    }
}
