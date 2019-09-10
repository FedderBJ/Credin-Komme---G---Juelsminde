using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Resources;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class fmWorkCenterRelation : Form
    {
        public fmWorkCenterRelation()
        {
            InitializeComponent();

            var dbWorkCenter = new WorkCenterRelationConnDataContext();
            var WorkCenters =
                from WorkCenter in dbWorkCenter.Credin_Employee_Work_Center_Relations
                where WorkCenter.Employee_No_.Equals(Employee.TheEmployeeNo)
                orderby WorkCenter.Sorting ascending
                select new { WorkCenter.Work_Center, WorkCenter.Work_Center_Name };

            if (WorkCenters.Count() > 0)
            {
                dgWorkshift.DataSource = WorkCenters;
                dgWorkshift.Update();
            }
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmWorkCenterRelation));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dgWorkshift.CurrentCell = dgWorkshift[0, dgWorkshift.CurrentCell.RowIndex];
            Employee.TheWorkingWorkCenter = dgWorkshift.CurrentCell.Value.ToString();
        }

        private void fmWorkCenterRelation_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
        }
    }
}
