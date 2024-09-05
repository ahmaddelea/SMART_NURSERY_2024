using DevExpress.XtraEditors;
using SMART_NURSERT_DATABASE_2024;
using SMART_NURSERT_DATABASE_2024.COMMANDER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMART_NURSERY_FORMS_2024.FORMS
{
    public partial class CHILD_FRM : MAIN_DATA_FRM
    {
        public CHILD_FRM()
        {
            InitializeComponent();
        }
        CLS_COMMANDER<CHILD_TBL> CMD_CHILD = new CLS_COMMANDER<CHILD_TBL>();
        CLS_COMMANDER<PARENT_INFO_TBL> CMD_PARENTS = new CLS_COMMANDER<PARENT_INFO_TBL>();

        CHILD_TBL Child;
        PARENT_INFO_TBL ParentInfo = new PARENT_INFO_TBL();

        private void CHILD_FRM_Load(object sender, EventArgs e)
        {
            GET_DATA();
        }
    }
}