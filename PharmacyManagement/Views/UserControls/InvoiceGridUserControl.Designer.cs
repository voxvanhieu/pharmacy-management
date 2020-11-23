
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.pharmacyDbDataSet = new PharmacyManagement.PharmacyDbDataSet();
            this.vInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_InvoiceTableAdapter = new PharmacyManagement.PharmacyDbDataSetTableAdapters.V_InvoiceTableAdapter();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommodities = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommodityQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.vInvoiceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(565, 373);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
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
            // pharmacyDbDataSet
            // 
            this.pharmacyDbDataSet.DataSetName = "PharmacyDbDataSet";
            this.pharmacyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vInvoiceBindingSource
            // 
            this.vInvoiceBindingSource.DataMember = "V_Invoice";
            this.vInvoiceBindingSource.DataSource = this.pharmacyDbDataSet;
            // 
            // v_InvoiceTableAdapter
            // 
            this.v_InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserName,
            this.colInvoiceType,
            this.colCommodities,
            this.colDescription,
            this.colProvider,
            this.colSaleUnit,
            this.colSalePrice,
            this.colCommodityQuantity,
            this.colNote,
            this.colCreated});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cardView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cardView1.OptionsBehavior.Editable = false;
            this.cardView1.OptionsBehavior.ReadOnly = true;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.FieldName = "Invoice Type";
            this.colInvoiceType.Name = "colInvoiceType";
            this.colInvoiceType.Visible = true;
            this.colInvoiceType.VisibleIndex = 2;
            // 
            // colCommodities
            // 
            this.colCommodities.FieldName = "Commodities";
            this.colCommodities.Name = "colCommodities";
            this.colCommodities.Visible = true;
            this.colCommodities.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colProvider
            // 
            this.colProvider.FieldName = "Provider";
            this.colProvider.Name = "colProvider";
            this.colProvider.Visible = true;
            this.colProvider.VisibleIndex = 5;
            // 
            // colSaleUnit
            // 
            this.colSaleUnit.FieldName = "SaleUnit";
            this.colSaleUnit.Name = "colSaleUnit";
            this.colSaleUnit.Visible = true;
            this.colSaleUnit.VisibleIndex = 6;
            // 
            // colSalePrice
            // 
            this.colSalePrice.FieldName = "SalePrice";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = true;
            this.colSalePrice.VisibleIndex = 7;
            // 
            // colCommodityQuantity
            // 
            this.colCommodityQuantity.FieldName = "CommodityQuantity";
            this.colCommodityQuantity.Name = "colCommodityQuantity";
            this.colCommodityQuantity.Visible = true;
            this.colCommodityQuantity.VisibleIndex = 8;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 9;
            // 
            // colCreated
            // 
            this.colCreated.FieldName = "Created";
            this.colCreated.Name = "colCreated";
            this.colCreated.Visible = true;
            this.colCreated.VisibleIndex = 10;
            // 
            // InvoiceGridUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.gridControl1);
            this.Name = "InvoiceGridUserControl";
            this.Size = new System.Drawing.Size(565, 405);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private System.Windows.Forms.BindingSource vInvoiceBindingSource;
        private PharmacyDbDataSet pharmacyDbDataSet;
        private PharmacyDbDataSetTableAdapters.V_InvoiceTableAdapter v_InvoiceTableAdapter;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
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
