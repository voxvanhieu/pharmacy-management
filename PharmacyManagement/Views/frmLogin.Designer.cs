
namespace PharmacyManagement.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox3 = new DevExpress.XtraEditors.SvgImageBox();
            this.txbPassword = new DevExpress.XtraEditors.TextEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbUsername = new DevExpress.XtraEditors.ComboBoxEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDbDataSet = new PharmacyManagement.PharmacyDbDataSet();
            this.usersTableAdapter = new PharmacyManagement.PharmacyDbDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPassword.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(424, 31);
            this.toolbarFormControl1.TabIndex = 0;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(424, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 227);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(424, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 196);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(424, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 196);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(110, 182);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(216, 182);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(12, 48);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(126, 116);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Zoom;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 11;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.svgImageBox2.Location = new System.Drawing.Point(3, 4);
            this.svgImageBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(45, 42);
            this.svgImageBox2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox2.SvgImage")));
            this.svgImageBox2.TabIndex = 13;
            this.svgImageBox2.Text = "svgImageBox2";
            // 
            // svgImageBox3
            // 
            this.svgImageBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.svgImageBox3.Location = new System.Drawing.Point(3, 54);
            this.svgImageBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.svgImageBox3.Name = "svgImageBox3";
            this.svgImageBox3.Size = new System.Drawing.Size(45, 41);
            this.svgImageBox3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox3.SvgImage")));
            this.svgImageBox3.TabIndex = 15;
            this.svgImageBox3.Text = "svgImageBox3";
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.Location = new System.Drawing.Point(54, 54);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPassword.MenuManager = this.toolbarFormManager1;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbPassword.Properties.Appearance.Options.UseFont = true;
            this.txbPassword.Properties.PasswordChar = '●';
            this.txbPassword.Size = new System.Drawing.Size(199, 28);
            this.txbPassword.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.svgImageBox2);
            this.flowLayoutPanel1.Controls.Add(this.cmbUsername);
            this.flowLayoutPanel1.Controls.Add(this.svgImageBox3);
            this.flowLayoutPanel1.Controls.Add(this.txbPassword);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 109);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // cmbUsername
            // 
            this.cmbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsername.Location = new System.Drawing.Point(54, 4);
            this.cmbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsername.MenuManager = this.toolbarFormManager1;
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbUsername.Properties.Appearance.Options.UseFont = true;
            this.cmbUsername.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUsername.Properties.Sorted = true;
            this.cmbUsername.Size = new System.Drawing.Size(199, 28);
            this.cmbUsername.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pharmacyDbDataSet;
            // 
            // pharmacyDbDataSet
            // 
            this.pharmacyDbDataSet.DataSetName = "PharmacyDbDataSet";
            this.pharmacyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 227);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy Manager Login";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPassword.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox3;
        private DevExpress.XtraEditors.TextEdit txbPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUsername;
        private PharmacyDbDataSet pharmacyDbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PharmacyDbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}