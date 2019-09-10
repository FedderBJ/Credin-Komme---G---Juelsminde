using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Resources;
using WindowsFormsApplication1.Produktion;
using System.Diagnostics;
using System.Globalization;

 

namespace WindowsFormsApplication1
{
    public partial class fmProductionReg : Form
    {
        public fmProductionReg()
        {
            InitializeComponent();
        }

        MyToolbox mt = new MyToolbox();
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmProductionReg));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void edtTextID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                switch (Globals.TheGlobalStep)
                {
                    case 1:
                        {
                            if (edtTextID.Text.Equals(""))
                                break;
                            lblHeaderText.Text = mt.ReadResFile(this.Name.ToString() +  "LeadText01");
                            
                            BalanceProduktion TimeJob = new BalanceProduktion();
                            TimeJob.UseDefaultCredentials = true;

                            if (Globals.TheGlobalCome)
                            {
                                try
                                {
                                    if (TimeJob.WSCreateProdRessLine(Employee.TheEmployeeNo, Employee.TheWorkingWorkCenter, DateTime.Now, DateTime.MinValue, "J"))
                                    {
                                        edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "OK01");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                TimeJob.Dispose();
                            }
                            else
                            {
                                try
                                {
                                    if (TimeJob.WSCreateProdRessLine(Employee.TheEmployeeNo, Employee.TheWorkingWorkCenter, DateTime.MinValue, DateTime.Now, "J"))
                                    {
                                        edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "OK01");
                                    }
                                    else
                                    {
                                        edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "ERROR01");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            Globals.TheGlobalStep = 0;
                            TimeJob.Dispose();
                            timer1.Interval = 1500;
                            timer1.Start();
                        }
                        break;
                }
            }

            if ((e.KeyChar == (char)Keys.Escape)  || (e.KeyChar == (char)Keys.Tab))
            {
                switch (Globals.TheGlobalStep)
                {
                    case 0: this.Close();
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmProductionReg_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
            lblHeaderText.Text = mt.ReadResFile(this.Name.ToString() + "lblHeaderText");
            edtTextID.Text = mt.ReadResFile(this.Name.ToString() + "Confirm01");
            tbNummer.Text = Employee.TheEmployeeNo;
            tbFirstName.Text = Employee.TheFirstName;
            tbLastName.Text = Employee.TheLastName;
            if (Employee.TheWorkingWorkCenter == "")
                Employee.TheWorkingWorkCenter = Employee.TheDefaultWorkCenter;
            tbWorkCenter.Text = Employee.TheWorkingWorkCenter + " " + mt.ReturnWorkCenterName(Employee.TheWorkingWorkCenter); ;
            this.ActiveControl = edtTextID;
            Globals.TheGlobalStep++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.TheGlobalStep = 0;
            this.Close();
        }
    }
}
