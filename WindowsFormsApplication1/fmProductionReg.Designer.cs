namespace WindowsFormsApplication1
{
    partial class fmProductionReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmProductionReg));
            this.edtTextID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lblWorkCenter = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbWorkCenter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edtTextID
            // 
            resources.ApplyResources(this.edtTextID, "edtTextID");
            this.edtTextID.Name = "edtTextID";
            this.edtTextID.TabStop = false;
            this.edtTextID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtTextID_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHeaderText
            // 
            resources.ApplyResources(this.lblHeaderText, "lblHeaderText");
            this.lblHeaderText.Name = "lblHeaderText";
            // 
            // lblWorkCenter
            // 
            resources.ApplyResources(this.lblWorkCenter, "lblWorkCenter");
            this.lblWorkCenter.Name = "lblWorkCenter";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblNo
            // 
            resources.ApplyResources(this.lblNo, "lblNo");
            this.lblNo.Name = "lblNo";
            // 
            // tbNummer
            // 
            resources.ApplyResources(this.tbNummer, "tbNummer");
            this.tbNummer.Name = "tbNummer";
            // 
            // tbFirstName
            // 
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            // 
            // tbLastName
            // 
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
            // 
            // tbWorkCenter
            // 
            resources.ApplyResources(this.tbWorkCenter, "tbWorkCenter");
            this.tbWorkCenter.Name = "tbWorkCenter";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmProductionReg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWorkCenter);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.tbNummer);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbWorkCenter);
            this.Controls.Add(this.lblHeaderText);
            this.Controls.Add(this.edtTextID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmProductionReg";
            this.Load += new System.EventHandler(this.fmProductionReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtTextID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Label lblWorkCenter;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbWorkCenter;
        private System.Windows.Forms.Button button1;
    }
}