namespace WindowsFormsApplication1
{
    partial class fmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMainMenu));
            this.lblProdAuftrag = new System.Windows.Forms.Label();
            this.lblArbeiter = new System.Windows.Forms.Label();
            this.pbWorkcenter = new System.Windows.Forms.PictureBox();
            this.pbRessource = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRessource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdAuftrag
            // 
            resources.ApplyResources(this.lblProdAuftrag, "lblProdAuftrag");
            this.lblProdAuftrag.Name = "lblProdAuftrag";
            // 
            // lblArbeiter
            // 
            resources.ApplyResources(this.lblArbeiter, "lblArbeiter");
            this.lblArbeiter.Name = "lblArbeiter";
            // 
            // pbWorkcenter
            // 
            this.pbWorkcenter.Image = global::WindowsFormsApplication1.Properties.Resources.RollMill_small;
            resources.ApplyResources(this.pbWorkcenter, "pbWorkcenter");
            this.pbWorkcenter.Name = "pbWorkcenter";
            this.pbWorkcenter.TabStop = false;
            this.pbWorkcenter.Click += new System.EventHandler(this.pbWorkcenter_Click);
            // 
            // pbRessource
            // 
            this.pbRessource.Image = global::WindowsFormsApplication1.Properties.Resources.Arbeiter_small;
            resources.ApplyResources(this.pbRessource, "pbRessource");
            this.pbRessource.Name = "pbRessource";
            this.pbRessource.TabStop = false;
            this.pbRessource.Click += new System.EventHandler(this.pbRessource_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fmMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblProdAuftrag);
            this.Controls.Add(this.lblArbeiter);
            this.Controls.Add(this.pbWorkcenter);
            this.Controls.Add(this.pbRessource);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmMainMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.fmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRessource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdAuftrag;
        private System.Windows.Forms.Label lblArbeiter;
        private System.Windows.Forms.PictureBox pbWorkcenter;
        private System.Windows.Forms.PictureBox pbRessource;
        private System.Windows.Forms.Timer timer1;
    }
}