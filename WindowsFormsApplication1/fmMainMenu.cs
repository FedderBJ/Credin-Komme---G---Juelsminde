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

namespace WindowsFormsApplication1
{
    public partial class fmMainMenu : Form
    {
        public fmMainMenu()
        {
            InitializeComponent();
        }
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(fmMainMenu));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        int TimeTick = 1;

        private void pbRessource_Click(object sender, EventArgs e)
        {
            Globals.TheGlobalProduction = false;
            fmMain RessourceMainForm = new fmMain();
            RessourceMainForm.Visible = true;
        }

        private void pbWorkcenter_Click(object sender, EventArgs e)
        {
            Globals.TheGlobalProduction = true;
            fmMain RessourceMainForm = new fmMain();
            RessourceMainForm.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTick++;
            if (TimeTick >= 5)
            {
                this.Close();
            }
        }
        private void fmMainMenu_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Employee.TheLanguageCode);
        }
    }
}
