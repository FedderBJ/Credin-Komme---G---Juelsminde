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
    public partial class fmAbsenceRelation : Form
    {
        public fmAbsenceRelation()
        {
            InitializeComponent();

            var dbAbsence = new AbsenceRelationConnDataContext();
            var Absences =
                from Absence in dbAbsence.Credin_Employee_Absence_Kode_Relations
                where Absence.Employee_No_.Equals(Employee.TheEmployeeNo)
                select new {Absence.Absence_Code, Absence.Absence_Name };

            if (Absences.Count() > 0)
            {
                dgAbsence.DataSource = Absences;
                dgAbsence.Update();
            }
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmAbsenceRelation));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dgAbsence.CurrentCell = dgAbsence[0, dgAbsence.CurrentCell.RowIndex];
            Employee.TheAbsenceCode = dgAbsence.CurrentCell.Value.ToString();
        }

        private void fmWorkCenterRelation_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
        }
    }
}
