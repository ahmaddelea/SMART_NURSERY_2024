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

namespace SMART_NUSERY_FORMS_2024.DATA_GRID_FORMS
{
    public partial class CLD_GRID : DevExpress.XtraEditors.XtraForm
    {
        public CLD_GRID()
        {
            InitializeComponent();
        }
        CLS_COMMANDER<CHILD_TBL> CMD_CHILD = new CLS_COMMANDER<CHILD_TBL>();
        CLS_COMMANDER<PARENT_INFO_TBL> CMD_PARENT = new CLS_COMMANDER<PARENT_INFO_TBL>();

        CHILD_TBL Child;
        PARENT_INFO_TBL Parent = new PARENT_INFO_TBL();

        private void CLD_GRID_Load(object sender, EventArgs e)
        {

        }
        public void SHOW_CLD_DATA()
        {
            GC_CLD.DataSource = (from Child in CMD_CHILD.GET_ALL()
                                 join Parent in CMD_PARENT.GET_ALL() on Child.PAR_ID equals Parent.PAR_ID
                                 select new
                                 {
                                     CHILD_ID = Child.CLD_ID,
                                     CHILD_NAME = Child.CLD_NAME,
                                     CHILD_P_DATE = Child.CLD_P_DATE,
                                     CHILD_GEN = Child.CLD_GEN,
                                     CHILD_LVL = Child.CLD_LVL,
                                     //CHILD_STATE = Child.CLD
                                     PARENT_ID = Child.PAR_ID,
                                     PARENT_NAME = Child.PARENT_INFO_TBL.PAR_NAME
                                 }).OrderBy(C_ID => C_ID.CHILD_ID);
            if (DGV_CLD.RowCount >= 1)
            {
                DGV_CLD.Columns["CHILD_ID"].Caption = "رقم الطفل";
                DGV_CLD.Columns["CHILD_NAME"].Caption = "الاسم الطفل";
                DGV_CLD.Columns["CHILD_P_DATE"].Caption = "تاريخ الميلاد";
                DGV_CLD.Columns["CHILD_GEN"].Caption = "جنس الطفل";
                DGV_CLD.Columns["CHILD_LVL"].Caption = "المستوى";
                DGV_CLD.Columns["PARENT_ID"].Caption = "رقم العائلة";
                DGV_CLD.Columns["PARENT_NAME"].Caption = "اسم العائلة";
                DGV_CLD.BestFitColumns();
            }
        }
        private void DGV_CLD_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}