
namespace PharmacyManagement.Views.UserControls
{
    partial class InvoiceGridUserControl
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
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDbDataSet = new PharmacyManagement.PharmacyDbDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommodities = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommodityQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_InvoiceTableAdapter = new PharmacyManagement.PharmacyDbDataSetTableAdapters.V_InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(487, 379);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.vInvoiceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(565, 373);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vInvoiceBindingSource
            // 
            this.vInvoiceBindingSource.DataMember = "V_Invoice";
            this.vInvoiceBindingSource.DataSource = this.pharmacyDbDataSet;
            // 
            // pharmacyDbDataSet
            // 
            this.pharmacyDbDataSet.DataSetName = "PharmacyDbDataSet";
            this.pharmacyDbDataSet.EnforceConstraints = false;
            this.pharmacyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserName,
            this.colInvoiceType,
            this.colTotalPrice,
            this.colCommodities,
            this.colDescription,
            this.colProvider,
            this.colSaleUnit,
            this.colSalePrice,
            this.colCommodityQuantity,
            this.colNote,
            this.colCreated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 34;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            this.colUserName.Width = 44;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.FieldName = "Invoice Type";
            this.colInvoiceType.Name = "colInvoiceType";
            this.colInvoiceType.Visible = true;
            this.colInvoiceType.VisibleIndex = 1;
            this.colInvoiceType.Width = 44;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 2;
            this.colTotalPrice.Width = 44;
            // 
            // colCommodities
            // 
            this.colCommodities.FieldName = "Commodities";
            this.colCommodities.Name = "colCommodities";
            this.colCommodities.Visible = true;
            this.colCommodities.VisibleIndex = 3;
            this.colCommodities.Width = 44;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 44;
            // 
            // colProvider
            // 
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            this.colProvider.VisibleIndex = 5;
            this.colProvider.Width = 44;
            // 
            // colSaleUnit
            // 
            this.colSaleUnit.FieldName = "SaleUnit";
            this.colSaleUnit.Name = "colSaleUnit";
            this.colSaleUnit.Visible = true;
            this.colSaleUnit.VisibleIndex = 6;
            this.colSaleUnit.Width = 44;
            // 
            // colSalePrice
            // 
            this.colSalePrice.FieldName = "SalePrice";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = true;
            this.colSalePrice.VisibleIndex = 7;
            this.colSalePrice.Width = 44;
            // 
            // colCommodityQuantity
            // 
            this.colCommodityQuantity.FieldName = "CommodityQuantity";
            this.colCommodityQuantity.Name = "colCommodityQuantity";
            this.colCommodityQuantity.Visible = true;
            this.colCommodityQuantity.VisibleIndex = 8;
            this.colCommodityQuantity.Width = 44;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 9;
            this.colNote.Width = 44;
            // 
            // colCreated
            // 
            this.colCreated.FieldName = "Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.Visible = true;
            this.colCreated.VisibleIndex = 10;
            this.colCreated.Width = 66;
            // 
            // v_InvoiceTableAdapter
            // 
            this.v_InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceGridUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnReload);
            this.Name = "InvoiceGridUserControl";
            this.Size = new System.Drawing.Size(565, 405);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource vInvoiceBindingSource;
        private PharmacyDbDataSetTableAdapters.V_InvoiceTableAdapter v_InvoiceTableAdapter;
        private PharmacyDbDataSet pharmacyDbDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodities;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCommodityQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
    }
}
