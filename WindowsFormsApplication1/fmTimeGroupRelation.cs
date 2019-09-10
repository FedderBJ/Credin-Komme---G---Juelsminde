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
    public partial class fmTimeGroupRelation : Form
    {
        public fmTimeGroupRelation()
        {
            InitializeComponent();

            var dbTimeGroup = new TimeGroupRelationConnDataContext();
            var TimeGroups =
            from TimeGroup in dbTimeGroup.Credin_Employee_Time_Group_Relations
            where TimeGroup.Employee_No_.Equals(Employee.TheEmployeeNo)
            select new { TimeGroup.Time_Group_No_, TimeGroup.Time_Group_Name };

            if (TimeGroups.Count() > 0)
            {
                dgWorkshift.DataSource = TimeGroups;
                dgWorkshift.Update();
            }
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmTimeGroupRelation));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgWorkshift.CurrentCell = dgWorkshift[0, dgWorkshift.CurrentCell.RowIndex];
            Employee.TheTimeGroupCode = dgWorkshift.CurrentCell.Value.ToString();
        }

        private void fmTimeGroupRelation_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
        }
    }
}
