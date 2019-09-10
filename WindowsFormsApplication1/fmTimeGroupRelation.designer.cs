namespace WindowsFormsApplication1
{
    partial class fmTimeGroupRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTimeGroupRelation));
            this.dgWorkshift = new System.Windows.Forms.DataGridView();
            this.timeGroupNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeGroupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credinEmployeeTimeGroupRelationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkshift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credinEmployeeTimeGroupRelationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWorkshift
            // 
            this.dgWorkshift.AllowUserToAddRows = false;
            this.dgWorkshift.AllowUserToDeleteRows = false;
            this.dgWorkshift.AllowUserToResizeColumns = false;
            this.dgWorkshift.AllowUserToResizeRows = false;
            this.dgWorkshift.AutoGenerateColumns = false;
            this.dgWorkshift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkshift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeGroupNoDataGridViewTextBoxColumn,
            this.timeGroupNameDataGridViewTextBoxColumn});
            this.dgWorkshift.DataSource = this.credinEmployeeTimeGroupRelationBindingSource;
            resources.ApplyResources(this.dgWorkshift, "dgWorkshift");
            this.dgWorkshift.Name = "dgWorkshift";
            this.dgWorkshift.ReadOnly = true;
            this.dgWorkshift.RowTemplate.Height = 30;
            // 
            // timeGroupNoDataGridViewTextBoxColumn
            // 
            this.timeGroupNoDataGridViewTextBoxColumn.DataPropertyName = "Time_Group_No_";
            resources.ApplyResources(this.timeGroupNoDataGridViewTextBoxColumn, "timeGroupNoDataGridViewTextBoxColumn");
            this.timeGroupNoDataGridViewTextBoxColumn.Name = "timeGroupNoDataGridViewTextBoxColumn";
            this.timeGroupNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeGroupNameDataGridViewTextBoxColumn
            // 
            this.timeGroupNameDataGridViewTextBoxColumn.DataPropertyName = "Time_Group_Name";
            resources.ApplyResources(this.timeGroupNameDataGridViewTextBoxColumn, "timeGroupNameDataGridViewTextBoxColumn");
            this.timeGroupNameDataGridViewTextBoxColumn.Name = "timeGroupNameDataGridViewTextBoxColumn";
            this.timeGroupNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // credinEmployeeTimeGroupRelationBindingSource
            // 
            this.credinEmployeeTimeGroupRelationBindingSource.DataSource = typeof(WindowsFormsApplication1.Resources.Credin_Employee_Time_Group_Relation);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmTimeGroupRelation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgWorkshift);
            this.Name = "fmTimeGroupRelation";
            this.Load += new System.EventHandler(this.fmTimeGroupRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkshift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credinEmployeeTimeGroupRelationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgWorkshift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource credinEmployeeTimeGroupRelationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeGroupNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeGroupNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn schedlueDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}