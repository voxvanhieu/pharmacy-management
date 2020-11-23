
namespace PharmacyManagement.Views.UserControls
{
    partial class CommodityUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vComodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDbDataSet = new PharmacyManagement.PharmacyDbDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_ComodityTableAdapter = new PharmacyManagement.PharmacyDbDataSetTableAdapters.V_ComodityTableAdapter();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComodityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.vComodityBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(698, 408);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vComodityBindingSource
            // 
            this.vComodityBindingSource.DataMember = "V_Comodity";
            this.vComodityBindingSource.DataSource = this.pharmacyDbDataSet;
            // 
            // pharmacyDbDataSet
            // 
            this.pharmacyDbDataSet.DataSetName = "PharmacyDbDataSet";
            this.pharmacyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colType,
            this.colDescription,
            this.colProvider,
            this.colTotalQuantity,
            this.colBaseUnitName,
            this.colBaseUnitPrice,
            this.colReferenceLink,
            this.colCreated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            // 
            // colProvider
            // 
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            this.colProvider.VisibleIndex = 4;
            // 
            // colTotalQuantity
            // 
            this.colTotalQuantity.FieldName = "TotalQuantity";
            this.colTotalQuantity.Name = "colTotalQuantity";
            this.colTotalQuantity.Visible = true;
            this.colTotalQuantity.VisibleIndex = 5;
            // 
            // colBaseUnitName
            // 
            this.colBaseUnitName.FieldName = "BaseUnitName";
            this.colBaseUnitName.Name = "colBaseUnitName";
            this.colBaseUnitName.Visible = true;
            this.colBaseUnitName.VisibleIndex = 6;
            // 
            // colBaseUnitPrice
            // 
            this.colBaseUnitPrice.FieldName = "BaseUnitPrice";
            this.colBaseUnitPrice.Name = "colBaseUnitPrice";
            this.colBaseUnitPrice.Visible = true;
            this.colBaseUnitPrice.VisibleIndex = 7;
            // 
            // colReferenceLink
            // 
            this.colReferenceLink.FieldName = "ReferenceLink";
            this.colReferenceLink.Name = "colReferenceLink";
            this.colReferenceLink.Visible = true;
            this.colReferenceLink.VisibleIndex = 8;
            // 
            // colCreated
            // 
            this.colCreated.FieldName = "Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.Visible = true;
            this.colCreated.VisibleIndex = 9;
            // 
            // v_ComodityTableAdapter
            // 
            this.v_ComodityTableAdapter.ClearBeforeFill = true;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(458, 414);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(620, 414);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(539, 414);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(3, 417);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(215, 13);
            this.hyperlinkLabelControl1.TabIndex = 7;
            this.hyperlinkLabelControl1.Text = "Tra cứu trên website của cục quản lý dược";
            // 
            // CommodityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gridControl1);
            this.Name = "CommodityUserControl";
            this.Size = new System.Drawing.Size(698, 440);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComodityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource vComodityBindingSource;
        private PharmacyDbDataSet pharmacyDbDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceLink;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
        private PharmacyDbDataSetTableAdapters.V_ComodityTableAdapter v_ComodityTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}
