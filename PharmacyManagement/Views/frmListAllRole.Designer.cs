namespace PharmacyManagement.Views
{
    partial class frmListAllRole
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
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.pharmacyDbDataSet = new PharmacyManagement.PharmacyDbDataSet();
            this.pharmacyDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.pharmacyDbDataSetBindingSource;
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(366, 409);
            this.listBoxControl1.TabIndex = 0;
            // 
            // pharmacyDbDataSet
            // 
            this.pharmacyDbDataSet.DataSetName = "PharmacyDbDataSet";
            this.pharmacyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacyDbDataSetBindingSource
            // 
            this.pharmacyDbDataSetBindingSource.DataSource = this.pharmacyDbDataSet;
            this.pharmacyDbDataSetBindingSource.Position = 0;
            // 
            // frmListAllRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 409);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "frmListAllRole";
            this.Text = "List roles";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.BindingSource pharmacyDbDataSetBindingSource;
        private PharmacyDbDataSet pharmacyDbDataSet;
    }
}