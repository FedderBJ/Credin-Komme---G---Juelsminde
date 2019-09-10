namespace WindowsFormsApplication1
{
    partial class fmAbsenceRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAbsenceRelation));
            this.dgAbsence = new System.Windows.Forms.DataGridView();
            this.absenceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credinEmployeeAbsenceKodeRelationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credinEmployeeAbsenceKodeRelationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAbsence
            // 
            this.dgAbsence.AllowUserToDeleteRows = false;
            this.dgAbsence.AllowUserToResizeColumns = false;
            this.dgAbsence.AllowUserToResizeRows = false;
            this.dgAbsence.AutoGenerateColumns = false;
            this.dgAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbsence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.absenceCodeDataGridViewTextBoxColumn,
            this.absenceNameDataGridViewTextBoxColumn});
            this.dgAbsence.DataSource = this.credinEmployeeAbsenceKodeRelationBindingSource;
            resources.ApplyResources(this.dgAbsence, "dgAbsence");
            this.dgAbsence.Name = "dgAbsence";
            this.dgAbsence.RowTemplate.Height = 30;
            // 
            // absenceCodeDataGridViewTextBoxColumn
            // 
            this.absenceCodeDataGridViewTextBoxColumn.DataPropertyName = "Absence_Code";
            resources.ApplyResources(this.absenceCodeDataGridViewTextBoxColumn, "absenceCodeDataGridViewTextBoxColumn");
            this.absenceCodeDataGridViewTextBoxColumn.Name = "absenceCodeDataGridViewTextBoxColumn";
            // 
            // absenceNameDataGridViewTextBoxColumn
            // 
            this.absenceNameDataGridViewTextBoxColumn.DataPropertyName = "Absence_Name";
            resources.ApplyResources(this.absenceNameDataGridViewTextBoxColumn, "absenceNameDataGridViewTextBoxColumn");
            this.absenceNameDataGridViewTextBoxColumn.Name = "absenceNameDataGridViewTextBoxColumn";
            // 
            // credinEmployeeAbsenceKodeRelationBindingSource
            // 
            this.credinEmployeeAbsenceKodeRelationBindingSource.DataSource = typeof(WindowsFormsApplication1.Resources.Credin_Employee_Absence_Kode_Relation);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmAbsenceRelation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgAbsence);
            this.Name = "fmAbsenceRelation";
            this.Load += new System.EventHandler(this.fmWorkCenterRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credinEmployeeAbsenceKodeRelationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAbsence;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource credinEmployeeAbsenceKodeRelationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenceNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn schedlueDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}