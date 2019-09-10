namespace WindowsFormsApplication1
{
    partial class fmComeGoNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmComeGoNew));
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.edtTextID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTimeGroup = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDefaultWorkCenter = new System.Windows.Forms.Label();
            this.lblTimeGroup = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbWorkshift = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeaderText
            // 
            resources.ApplyResources(this.lblHeaderText, "lblHeaderText");
            this.lblHeaderText.Name = "lblHeaderText";
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTimeGroup
            // 
            resources.ApplyResources(this.tbTimeGroup, "tbTimeGroup");
            this.tbTimeGroup.Name = "tbTimeGroup";
            this.tbTimeGroup.TabStop = false;
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.tbName.TabStop = false;
            // 
            // tbNummer
            // 
            resources.ApplyResources(this.tbNummer, "tbNummer");
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.TabStop = false;
            // 
            // lblNo
            // 
            resources.ApplyResources(this.lblNo, "lblNo");
            this.lblNo.Name = "lblNo";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblDefaultWorkCenter
            // 
            resources.ApplyResources(this.lblDefaultWorkCenter, "lblDefaultWorkCenter");
            this.lblDefaultWorkCenter.Name = "lblDefaultWorkCenter";
            // 
            // lblTimeGroup
            // 
            resources.ApplyResources(this.lblTimeGroup, "lblTimeGroup");
            this.lblTimeGroup.Name = "lblTimeGroup";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbWorkshift
            // 
            resources.ApplyResources(this.tbWorkshift, "tbWorkshift");
            this.tbWorkshift.Name = "tbWorkshift";
            this.tbWorkshift.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmComeGoNew
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbWorkshift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTimeGroup);
            this.Controls.Add(this.lblDefaultWorkCenter);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.tbNummer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTimeGroup);
            this.Controls.Add(this.lblHeaderText);
            this.Controls.Add(this.edtTextID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmComeGoNew";
            this.Load += new System.EventHandler(this.fmComeGoNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.TextBox edtTextID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbTimeGroup;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDefaultWorkCenter;
        private System.Windows.Forms.Label lblTimeGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbWorkshift;
        private System.Windows.Forms.Button button2;
    }
}