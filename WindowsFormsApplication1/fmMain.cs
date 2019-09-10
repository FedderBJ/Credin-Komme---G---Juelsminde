using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using WindowsFormsApplication1.Resources;
using WindowsFormsApplication1.Produktion;

namespace WindowsFormsApplication1
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmMain));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        int TimeTick = 1;

        private DialogResult GetWorkCenter()
        {
            var dbWorkCenter = new WorkCenterRelationConnDataContext();
            var WorkCenters =
                from WorkCenter in dbWorkCenter.Credin_Employee_Work_Center_Relations
                where WorkCenter.Employee_No_.Equals(Employee.TheEmployeeNo)
                select new { WorkCenter.Work_Center, WorkCenter.Work_Center_Name };

            if (WorkCenters.Count() > 0)
            {
                fmWorkCenterRelation wcr = new fmWorkCenterRelation();
                return wcr.ShowDialog();
            }
            else
            {
                Employee.TheWorkingWorkCenter = Employee.TheDefaultWorkCenter;
                return System.Windows.Forms.DialogResult.None;
            }
        }
        private DialogResult GetTimeGroup()
        {
            BalanceProduktion Credin = new BalanceProduktion();
            Credin.UseDefaultCredentials = true;

            int direction = 0;
            if (Globals.TheGlobalCome)
                direction = 1;
            else
                direction = 2;
            bool vis = false;
            bool visTg = Credin.WSReturnSelectTimeGroup();
            bool visAb = Credin.WSShowAbsence(Employee.TheEmployeeNo, Employee.TheTimeGroupCode, DateTime.Now, direction); 
            
            if ((visAb == true) && (visTg == true))
            { vis = true; }
            if ((visAb == false) && (visTg == true))
            { vis = true; }
            if ((visAb == true) && (visTg == false))
            { vis = false; }
            if ((visAb == false) && (visTg == false))
            { vis = false; }



            if (vis) 
            {
                var dbTimeGroup = new TimeGroupRelationConnDataContext();
                var TimeGroups =
                from TimeGroup in dbTimeGroup.Credin_Employee_Time_Group_Relations
                where TimeGroup.Employee_No_.Equals(Employee.TheEmployeeNo)
                select new { TimeGroup.Time_Group_No_, TimeGroup.Time_Group_Name };

                if (TimeGroups.Count() > 0)
                {
                    fmTimeGroupRelation tgr = new fmTimeGroupRelation();
                    return tgr.ShowDialog();
                }
            }
            return System.Windows.Forms.DialogResult.None;
        }
        private DialogResult GetAbsence()
        {
            BalanceProduktion Credin = new BalanceProduktion();
            Credin.UseDefaultCredentials = true;
            int direction = 0;
            if (Globals.TheGlobalCome)
                direction = 1;
            else
                direction = 2;
            bool vis = Credin.WSShowAbsence(Employee.TheEmployeeNo, Employee.TheTimeGroupCode, DateTime.Now, direction);
            if (vis)
            {
                var dbAbsence = new AbsenceRelationConnDataContext();
                var Absences =
                    from Absence in dbAbsence.Credin_Employee_Absence_Kode_Relations
                    where Absence.Employee_No_.Equals(Employee.TheEmployeeNo)
                    select new { Absence.Absence_Code, Absence.Absence_Name };
                if (Absences.Count() > 0)
                {
                    fmAbsenceRelation ar = new fmAbsenceRelation();
                    return ar.ShowDialog();
                }
            }
            return System.Windows.Forms.DialogResult.None;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Globals.TheGlobalCome = true;
            if (!Globals.TheGlobalProduction)
            {
                if (GetTimeGroup() == System.Windows.Forms.DialogResult.OK)
                {
                }

                if(GetAbsence() != System.Windows.Forms.DialogResult.OK)
                {
                }

                fmComeGoNew cg = new fmComeGoNew();
                cg.Visible = true;
            }
            else
            {
                if (GetWorkCenter() == System.Windows.Forms.DialogResult.OK)
                {
                }
                fmProductionReg pr = new fmProductionReg();
                Globals.TheGlobalCome = true;
                pr.Visible = true;
            }
            this.Close();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (!Globals.TheGlobalProduction)
            {
                Globals.TheGlobalCome = false;
                if (GetTimeGroup() == System.Windows.Forms.DialogResult.OK)
                {
                }

                if (GetAbsence() != System.Windows.Forms.DialogResult.OK)
                {
                }
                fmComeGoNew cg = new fmComeGoNew();
                cg.Visible = true;
            }
            else
            {
                fmProductionReg pr = new fmProductionReg();
                Globals.TheGlobalCome = false;
                pr.Visible = true;
            }
            this.Close();
        }
        private void fmMain_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timeFormVisible_Tick(object sender, EventArgs e)
        {
            TimeTick++;
            if (TimeTick >= 10)
            {
                this.Close();
            }
        }
        private void fmMain_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
        }
    }
}
