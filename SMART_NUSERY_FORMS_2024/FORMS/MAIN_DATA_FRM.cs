using DevExpress.XtraEditors;
using SMART_NURSERT_DATABASE_2024;
using SMART_NURSERY_FORMS_2024;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SMART_NURSERY_FORMS_2024.FORMS
{
    public partial class MAIN_DATA_FRM : DevExpress.XtraEditors.XtraForm
    {
        public MAIN_DATA_FRM()
        {
            InitializeComponent();
        }
        //// CONTROL BOX AND DRAGABLE PANEL
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HTCAPTION = 0x2;
        //[DllImport("User32.dll")]
        //public static extern bool ReleaseCapture();
        //[DllImport("User32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        //    }
        //}

        //private void BTN_CLOSE_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        //private void BTN_MAXIMIZE_Click(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Normal)
        //    {
        //        WindowState = FormWindowState.Maximized;
        //    }
        //    else
        //    {
        //        WindowState = FormWindowState.Normal;
        //    }
        //}

        //private void BTN_MINIMIZE_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}
        private void MAIN_DATA_FRM_Load(object sender, EventArgs e)
        {

        }
        public virtual void GET_DATA()
        {

        }
        public virtual void INSERT_DATA()
        {
            LBL_CHANGE.Text = "تم الادخال بنجاح";
            LBL_CHANGE.ForeColor = Color.LimeGreen;
        }
        public virtual void UPDATE_DATA()
        {
            LBL_CHANGE.Text = "تم التعديل البيانات بنجاح";
            LBL_CHANGE.ForeColor = Color.LimeGreen;
        }
        public virtual string DELETE_DATA()
        {
            DialogResult DR = MessageBox.Show("هل تريد حذف البيانات؟", "!! تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DR == DialogResult.Yes)
            {
                return "TRUE";
            }

            else
            {
                return "FALSE";
            }
        }
        public virtual void CLEAR_DATA(Control.ControlCollection CONTROLS)
        {
            LBL_CHANGE.Text = "";
            Action<Control.ControlCollection> FUNC = null;
            FUNC = (controls) =>
            {
                foreach (Control control in CONTROLS)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is DateEdit)
                        (control as DateEdit).DateTime = DateTime.Now;
                    else if (control is TimeEdit)
                        (control as TimeEdit).Time = DateTime.Now;
                    else
                        FUNC(control.Controls);
             
            };
            FUNC(CONTROLS);
        }
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            INSERT_DATA();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            UPDATE_DATA();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            DELETE_DATA();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            CLEAR_DATA(this.Controls);
        }

        private void BTN_GRID_Click(object sender, EventArgs e)
        {

        }


    }
}