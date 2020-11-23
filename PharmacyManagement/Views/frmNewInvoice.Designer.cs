namespace PharmacyManagement.Views
{
    partial class frmNewInvoice
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txbQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbInvoideType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCommodities = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txbName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.dateBirthday = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoideType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommodities.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Location = new System.Drawing.Point(51, 203);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 41);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Add to cart";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuantity.Location = new System.Drawing.Point(136, 64);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txbQuantity.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantity.Properties.Appearance.Options.UseFont = true;
            this.txbQuantity.Size = new System.Drawing.Size(88, 32);
            this.txbQuantity.TabIndex = 18;
            this.txbQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txbQuantity_Validating);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(149, 36);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 23);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Quantity";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // cmbInvoideType
            // 
            this.cmbInvoideType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInvoideType.Location = new System.Drawing.Point(428, 98);
            this.cmbInvoideType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbInvoideType.Name = "cmbInvoideType";
            this.cmbInvoideType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvoideType.Properties.Appearance.Options.UseFont = true;
            this.cmbInvoideType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoideType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbInvoideType.Size = new System.Drawing.Size(191, 32);
            this.cmbInvoideType.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(321, 101);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(95, 23);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Invoice Type";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.textEdit3);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.textEdit2);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.cmbCommodities);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.txbQuantity);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Location = new System.Drawing.Point(428, 181);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(244, 303);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Commodities";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(51, 252);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(150, 41);
            this.simpleButton2.TabIndex = 28;
            this.simpleButton2.Text = "Remove from cart";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmbCommodities
            // 
            this.cmbCommodities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCommodities.Location = new System.Drawing.Point(20, 64);
            this.cmbCommodities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCommodities.Name = "cmbCommodities";
            this.cmbCommodities.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCommodities.Properties.Appearance.Options.UseFont = true;
            this.cmbCommodities.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCommodities.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCommodities.Size = new System.Drawing.Size(100, 32);
            this.cmbCommodities.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 36);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 23);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Commodities";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(321, 56);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 23);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Date created";
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.Enabled = false;
            this.txbName.Location = new System.Drawing.Point(113, 50);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Properties.Appearance.Options.UseFont = true;
            this.txbName.Size = new System.Drawing.Size(167, 32);
            this.txbName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.labelControl1.Location = new System.Drawing.Point(12, 101);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Note";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNote);
            this.groupControl1.Controls.Add(this.dateBirthday);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txbName);
            this.groupControl1.Controls.Add(this.cmbInvoideType);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(33, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(639, 160);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Basic information";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.labelControl4.Location = new System.Drawing.Point(12, 54);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 25);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Making by";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(113, 98);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Size = new System.Drawing.Size(167, 32);
            this.txtNote.TabIndex = 20;
            // 
            // dateBirthday
            // 
            this.dateBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBirthday.EditValue = null;
            this.dateBirthday.Location = new System.Drawing.Point(428, 50);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirthday.Properties.Appearance.Options.UseFont = true;
            this.dateBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBirthday.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateBirthday.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateBirthday.Size = new System.Drawing.Size(191, 32);
            this.dateBirthday.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(233, 443);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(150, 41);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "Checkout";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 208);
            this.listBox1.TabIndex = 30;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.listBox1);
            this.groupControl3.Location = new System.Drawing.Point(33, 181);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(380, 254);
            this.groupControl3.TabIndex = 28;
            this.groupControl3.Text = "Cart";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.EditValue = "TOTAL: 0";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(48, 447);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Size = new System.Drawing.Size(167, 34);
            this.textEdit1.TabIndex = 22;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.Location = new System.Drawing.Point(20, 150);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(101, 32);
            this.textEdit2.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 120);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 23);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Unit Name";
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit3.Location = new System.Drawing.Point(136, 150);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(88, 32);
            this.textEdit3.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(142, 121);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 23);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Unit Price";
            this.labelControl6.Validating += new System.ComponentModel.CancelEventHandler(this.txbQuantity_Validating);
            // 
            // frmNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 497);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNewInvoice";
            this.Text = "New Invoice";
            this.Load += new System.EventHandler(this.frmNewInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoideType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommodities.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txbQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cmbInvoideType;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txbName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCommodities;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateBirthday;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}