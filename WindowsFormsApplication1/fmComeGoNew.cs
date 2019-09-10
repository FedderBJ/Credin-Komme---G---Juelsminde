using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using WindowsFormsApplication1.Resources;
using WindowsFormsApplication1.Produktion;
using System.Diagnostics;
using System.Globalization;
namespace WindowsFormsApplication1
{
    public partial class fmComeGoNew : Form
    {
        public fmComeGoNew()
        {
            InitializeComponent();
            /*
            if (Globals.TheGlobalCome)
            {
               
                var dbWorkCenter = new WorkCenterRelationConnDataContext();
                var WorkCenters =
                    from WorkCenter in dbWorkCenter.Credin_Employee_Work_Center_Relations
                    where WorkCenter.Employee_No_.Equals(Employee.TheEmployeeNo)
                    orderby WorkCenter.Sorting ascending
                    select new {WorkCenter, Names = WorkCenter.Work_Center + ", " + WorkCenter.Work_Center_Name };

                if (WorkCenters.Count() > 0)
                {
                    cbWorkshift.DataSource = WorkCenters;
                    cbWorkshift.DisplayMember = "Names";
                    cbWorkshift.Update();
                }
                else
                {
                    tbWorkshift.Text = Employee.TheDefaultWorkCenter + ", " + mt.ReturnWorkCenterName(Employee.TheDefaultWorkCenter);
                }
            }*/
        }

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

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmComeGoNew));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
        MyToolbox mt = new MyToolbox();
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void edtTextID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Escape) || (e.KeyChar == (char)Keys.Tab))
            {
                switch (Globals.TheGlobalStep)
                {
                    case 1: this.Close();
                        break;
                    case 0: this.Close();
                        break;
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                switch (Globals.TheGlobalStep)
                {
                    case 1:
                        {
                            BalanceProduktion TimeJob = new BalanceProduktion();
                            TimeJob.UseDefaultCredentials = true;
                            if (Globals.TheGlobalCome)
                            {
                                try
                                {
                                    if (TimeJob.WSCreateTimeStampLine(Employee.TheEmployeeNo, Employee.TheTimeGroupCode, Employee.TheAbsenceCode, DateTime.Now.Date, DateTime.Now, 1))
                                    {
                                        edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "OK01");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                timer1.Interval = 1500;
                                timer1.Start();
                            }
                            else
                            {
                                try
                                {
                                    if (TimeJob.WSCreateTimeStampLine(Employee.TheEmployeeNo, Employee.TheTimeGroupCode, Employee.TheAbsenceCode, DateTime.Now.Date, DateTime.Now, 2))
                                    {
                                        edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "OK01");

                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                timer1.Interval = 1500;
                                timer1.Start();
                            }
                            Globals.TheGlobalStep = 0;
                            TimeJob.Dispose();

                        }
                        break;
                }
            }
        }

        private void fmComeGoNew_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
            this.ActiveControl = edtTextID;
            if (Employee.TheEmployeeNo != "")
            {
                tbNummer.Text = Employee.TheEmployeeNo;
                if (Employee.TheWorkingWorkCenter == "")
                    Employee.TheWorkingWorkCenter = Employee.TheDefaultWorkCenter;
                tbWorkshift.Text = Employee.TheWorkingWorkCenter + " " + mt.ReturnWorkCenterName(Employee.TheWorkingWorkCenter);
                tbName.Text = Employee.TheFirstName + " " + Employee.TheLastName;
                if (Employee.TheAbsenceCode != "")
                {
                    lblTimeGroup.Text = mt.ReadResFile(this.Name.ToString() + "lblTimeGroup");
                    tbTimeGroup.Text = Employee.TheAbsenceCode + " " + mt.ReturAbsenceName(Employee.TheAbsenceCode);
                }
                else
                    tbTimeGroup.Text = Employee.TheTimeGroupCode;
                lblHeaderText.Text = mt.ReadResFile(this.Name.ToString() + "LeadText01");
                edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "Confirm01"); 
                Globals.TheGlobalStep++;
            }
            else
            {
                edtTextID.Text = "";
                MessageBox.Show(mt.ReadResFile(this.Name.ToString() + "Error01"));
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.TheGlobalStep = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetWorkCenter();
            tbWorkshift.Text = Employee.TheWorkingWorkCenter + " " + mt.ReturnWorkCenterName(Employee.TheWorkingWorkCenter);
            edtTextID.Focus();
            edtTextID.SelectAll();
        }
    }
}
