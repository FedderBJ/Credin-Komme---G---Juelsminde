namespace WindowsFormsApplication1
{
    partial class fmWorkCenterRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmWorkCenterRelation));
            this.dgWorkshift = new System.Windows.Forms.DataGridView();
            this.workCenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workCenterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credinEmployeeWorkCenterRelationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkshift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credinEmployeeWorkCenterRelationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWorkshift
            // 
            this.dgWorkshift.AllowUserToDeleteRows = false;
            this.dgWorkshift.AllowUserToResizeColumns = false;
            this.dgWorkshift.AllowUserToResizeRows = false;
            this.dgWorkshift.AutoGenerateColumns = false;
            this.dgWorkshift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWorkshift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workCenterDataGridViewTextBoxColumn,
            this.workCenterNameDataGridViewTextBoxColumn});
            this.dgWorkshift.DataSource = this.credinEmployeeWorkCenterRelationBindingSource;
            resources.ApplyResources(this.dgWorkshift, "dgWorkshift");
            this.dgWorkshift.Name = "dgWorkshift";
            this.dgWorkshift.RowTemplate.Height = 30;
            // 
            // workCenterDataGridViewTextBoxColumn
            // 
            this.workCenterDataGridViewTextBoxColumn.DataPropertyName = "Work_Center";
            resources.ApplyResources(this.workCenterDataGridViewTextBoxColumn, "workCenterDataGridViewTextBoxColumn");
            this.workCenterDataGridViewTextBoxColumn.Name = "workCenterDataGridViewTextBoxColumn";
            this.workCenterDataGridViewTextBoxColumn.ReadOnly = true;
            this.workCenterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // workCenterNameDataGridViewTextBoxColumn
            // 
            this.workCenterNameDataGridViewTextBoxColumn.DataPropertyName = "Work_Center_Name";
            resources.ApplyResources(this.workCenterNameDataGridViewTextBoxColumn, "workCenterNameDataGridViewTextBoxColumn");
            this.workCenterNameDataGridViewTextBoxColumn.Name = "workCenterNameDataGridViewTextBoxColumn";
            this.workCenterNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // credinEmployeeWorkCenterRelationBindingSource
            // 
            this.credinEmployeeWorkCenterRelationBindingSource.DataSource = typeof(WindowsFormsApplication1.Resources.Credin_Employee_Work_Center_Relation);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmWorkCenterRelation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgWorkshift);
            this.Name = "fmWorkCenterRelation";
            this.Load += new System.EventHandler(this.fmWorkCenterRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkshift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credinEmployeeWorkCenterRelationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgWorkshift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource credinEmployeeWorkCenterRelationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn workCenterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workCenterNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn schedlueDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}