namespace WindowsFormsApplication1
{
    partial class fmFirstScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmFirstScreen));
            this.tbEmployeeCard = new System.Windows.Forms.TextBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.pbNav4 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tmTimer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNav4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeCard
            // 
            resources.ApplyResources(this.tbEmployeeCard, "tbEmployeeCard");
            this.tbEmployeeCard.Name = "tbEmployeeCard";
            this.tbEmployeeCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmployeeCard_KeyPress);
            // 
            // lblClock
            // 
            resources.ApplyResources(this.lblClock, "lblClock");
            this.lblClock.Name = "lblClock";
            // 
            // pbNav4
            // 
            this.pbNav4.Image = global::WindowsFormsApplication1.Properties.Resources.NAV4Production;
            resources.ApplyResources(this.pbNav4, "pbNav4");
            this.pbNav4.Name = "pbNav4";
            this.pbNav4.TabStop = false;
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            this.pbLogo.DoubleClick += new System.EventHandler(this.pbLogo_DoubleClick);
            // 
            // tmTimer2
            // 
            this.tmTimer2.Enabled = true;
            this.tmTimer2.Interval = 1000;
            this.tmTimer2.Tick += new System.EventHandler(this.tmTimer2_Tick);
            // 
            // fmFirstScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.pbNav4);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbEmployeeCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmFirstScreen";
            this.Activated += new System.EventHandler(this.FirstScreen_Activated);
            this.Load += new System.EventHandler(this.FirstScreen_Load);
            this.Enter += new System.EventHandler(this.FirstScreen_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pbNav4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeCard;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.PictureBox pbNav4;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Timer tmTimer2;
    }
}