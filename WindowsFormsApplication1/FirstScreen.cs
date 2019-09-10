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
    public partial class fmFirstScreen : Form
    {
        //int i = 0;
        
        public fmFirstScreen()
        {
            InitializeComponent();
        }

        MyToolbox mt = new MyToolbox();
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmFirstScreen));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void tbEmployeeCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!tbEmployeeCard.Text.Equals(""))
                {
                    Employee.TheAbsenceCode = "";
                    Employee.TheCardNo = "";
                    Employee.TheDefaultWorkCenter = "";
                    Employee.TheEmployeeNo = "";
                    Employee.TheFirstName = "";
                    Employee.TheLanguageCode = "";
                    Employee.TheLastName = "";
                    Employee.TheTimeGroupCode = "";
                    Employee.TheWorkingWorkCenter = "";

                    var dbEmployee = new EmployeeConnDataContext();
                    var employees =
                    from employee in dbEmployee.Credin_Employees
                    where employee.Card_No_.Equals(tbEmployeeCard.Text.ToString())
                    select new { employee.First_Name, employee.Last_Name, employee.Card_No_, employee.No_, employee.Terminal_Language_Code, employee.Time_Group_Code, employee.Default_Work_Center};

                    if (employees.Count() > 0)
                    {
                        foreach (var item in employees)
                        {
                            Employee.TheEmployeeNo = item.No_;
                            if (item.Terminal_Language_Code == "")
                            {
                                Employee.TheLanguageCode = "da-DK";
                            }
                            else
                            {
                                Employee.TheLanguageCode = item.Terminal_Language_Code;
                            }
                            Employee.TheCardNo = item.Card_No_;
                            Employee.TheFirstName = item.First_Name;
                            Employee.TheLastName = item.Last_Name;
                            Employee.TheTimeGroupCode = item.Time_Group_Code;
                            Employee.TheDefaultWorkCenter = item.Default_Work_Center;
                            tbEmployeeCard.Text = "";
                            fmMainMenu Main = new fmMainMenu();
                            Main.Visible = true;
                            this.ActiveControl = tbEmployeeCard;
                        }
                    }
                }
                tbEmployeeCard.Text = "";
            }
        }

        private void FirstScreen_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = tbEmployeeCard;
        }

        private void FirstScreen_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = tbEmployeeCard;
        }

        private void FirstScreen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbEmployeeCard;
        }

        private void pbFob2_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmTimer2_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
