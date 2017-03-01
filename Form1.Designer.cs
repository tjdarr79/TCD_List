namespace TCD_List
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wallMountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desktopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotswapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCD_ListDataSet = new TCD_List.TCD_ListDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCIM = new System.Windows.Forms.Button();
            this.btnWallMount = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDesktop = new System.Windows.Forms.Button();
            this.btnHotSwap = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tCDTableAdapter = new TCD_List.TCD_ListDataSetTableAdapters.TCDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCD_ListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tCDNameDataGridViewTextBoxColumn,
            this.serviceNumberDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.cIMDataGridViewTextBoxColumn,
            this.wallMountDataGridViewTextBoxColumn,
            this.desktopDataGridViewTextBoxColumn,
            this.hotswapDataGridViewTextBoxColumn,
            this.dOADataGridViewTextBoxColumn,
            this.vNCDataGridViewTextBoxColumn,
            this.securedDataGridViewTextBoxColumn,
            this.mACDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tCDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 563);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Row";
            this.Column1.Name = "Column1";
            this.Column1.Width = 54;
            // 
            // tCDNameDataGridViewTextBoxColumn
            // 
            this.tCDNameDataGridViewTextBoxColumn.DataPropertyName = "TCD_Name";
            this.tCDNameDataGridViewTextBoxColumn.HeaderText = "TCD_Name";
            this.tCDNameDataGridViewTextBoxColumn.Name = "tCDNameDataGridViewTextBoxColumn";
            this.tCDNameDataGridViewTextBoxColumn.Width = 88;
            // 
            // serviceNumberDataGridViewTextBoxColumn
            // 
            this.serviceNumberDataGridViewTextBoxColumn.DataPropertyName = "Service_Number";
            this.serviceNumberDataGridViewTextBoxColumn.HeaderText = "Service_Number";
            this.serviceNumberDataGridViewTextBoxColumn.Name = "serviceNumberDataGridViewTextBoxColumn";
            this.serviceNumberDataGridViewTextBoxColumn.Width = 111;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 73;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.Width = 60;
            // 
            // cIMDataGridViewTextBoxColumn
            // 
            this.cIMDataGridViewTextBoxColumn.DataPropertyName = "CIM";
            this.cIMDataGridViewTextBoxColumn.HeaderText = "CIM";
            this.cIMDataGridViewTextBoxColumn.Name = "cIMDataGridViewTextBoxColumn";
            this.cIMDataGridViewTextBoxColumn.Width = 51;
            // 
            // wallMountDataGridViewTextBoxColumn
            // 
            this.wallMountDataGridViewTextBoxColumn.DataPropertyName = "Wall_Mount";
            this.wallMountDataGridViewTextBoxColumn.HeaderText = "Wall_Mount";
            this.wallMountDataGridViewTextBoxColumn.Name = "wallMountDataGridViewTextBoxColumn";
            this.wallMountDataGridViewTextBoxColumn.Width = 89;
            // 
            // desktopDataGridViewTextBoxColumn
            // 
            this.desktopDataGridViewTextBoxColumn.DataPropertyName = "Desktop";
            this.desktopDataGridViewTextBoxColumn.HeaderText = "Desktop";
            this.desktopDataGridViewTextBoxColumn.Name = "desktopDataGridViewTextBoxColumn";
            this.desktopDataGridViewTextBoxColumn.Width = 72;
            // 
            // hotswapDataGridViewTextBoxColumn
            // 
            this.hotswapDataGridViewTextBoxColumn.DataPropertyName = "Hot_swap";
            this.hotswapDataGridViewTextBoxColumn.HeaderText = "Hot_swap";
            this.hotswapDataGridViewTextBoxColumn.Name = "hotswapDataGridViewTextBoxColumn";
            this.hotswapDataGridViewTextBoxColumn.Width = 80;
            // 
            // dOADataGridViewTextBoxColumn
            // 
            this.dOADataGridViewTextBoxColumn.DataPropertyName = "DOA";
            this.dOADataGridViewTextBoxColumn.HeaderText = "DOA";
            this.dOADataGridViewTextBoxColumn.Name = "dOADataGridViewTextBoxColumn";
            this.dOADataGridViewTextBoxColumn.Width = 55;
            // 
            // vNCDataGridViewTextBoxColumn
            // 
            this.vNCDataGridViewTextBoxColumn.DataPropertyName = "VNC";
            this.vNCDataGridViewTextBoxColumn.HeaderText = "VNC";
            this.vNCDataGridViewTextBoxColumn.Name = "vNCDataGridViewTextBoxColumn";
            this.vNCDataGridViewTextBoxColumn.Width = 54;
            // 
            // securedDataGridViewTextBoxColumn
            // 
            this.securedDataGridViewTextBoxColumn.DataPropertyName = "Secured";
            this.securedDataGridViewTextBoxColumn.HeaderText = "Secured";
            this.securedDataGridViewTextBoxColumn.Name = "securedDataGridViewTextBoxColumn";
            this.securedDataGridViewTextBoxColumn.Width = 72;
            // 
            // mACDataGridViewTextBoxColumn
            // 
            this.mACDataGridViewTextBoxColumn.DataPropertyName = "MAC";
            this.mACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.mACDataGridViewTextBoxColumn.Name = "mACDataGridViewTextBoxColumn";
            this.mACDataGridViewTextBoxColumn.Width = 55;
            // 
            // tCDBindingSource
            // 
            this.tCDBindingSource.DataMember = "TCD";
            this.tCDBindingSource.DataSource = this.tCD_ListDataSet;
            this.tCDBindingSource.CurrentChanged += new System.EventHandler(this.tCDBindingSource_CurrentChanged);
            // 
            // tCD_ListDataSet
            // 
            this.tCD_ListDataSet.DataSetName = "TCD_ListDataSet";
            this.tCD_ListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(934, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCIM
            // 
            this.btnCIM.Location = new System.Drawing.Point(120, 20);
            this.btnCIM.Name = "btnCIM";
            this.btnCIM.Size = new System.Drawing.Size(75, 23);
            this.btnCIM.TabIndex = 2;
            this.btnCIM.Text = "CIM";
            this.btnCIM.UseVisualStyleBackColor = true;
            this.btnCIM.Click += new System.EventHandler(this.btnCIM_Click);
            // 
            // btnWallMount
            // 
            this.btnWallMount.Location = new System.Drawing.Point(201, 21);
            this.btnWallMount.Name = "btnWallMount";
            this.btnWallMount.Size = new System.Drawing.Size(75, 23);
            this.btnWallMount.TabIndex = 3;
            this.btnWallMount.Text = "Wall Mount";
            this.btnWallMount.UseVisualStyleBackColor = true;
            this.btnWallMount.Click += new System.EventHandler(this.btnWallMount_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(39, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDesktop
            // 
            this.btnDesktop.Location = new System.Drawing.Point(282, 21);
            this.btnDesktop.Name = "btnDesktop";
            this.btnDesktop.Size = new System.Drawing.Size(75, 23);
            this.btnDesktop.TabIndex = 5;
            this.btnDesktop.Text = "Desktop";
            this.btnDesktop.UseVisualStyleBackColor = true;
            this.btnDesktop.Click += new System.EventHandler(this.btnDesktop_Click);
            // 
            // btnHotSwap
            // 
            this.btnHotSwap.Location = new System.Drawing.Point(363, 21);
            this.btnHotSwap.Name = "btnHotSwap";
            this.btnHotSwap.Size = new System.Drawing.Size(75, 23);
            this.btnHotSwap.TabIndex = 6;
            this.btnHotSwap.Text = "Hot Swap";
            this.btnHotSwap.UseVisualStyleBackColor = true;
            this.btnHotSwap.Click += new System.EventHandler(this.btnHotSwap_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(842, 21);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tCDTableAdapter
            // 
            this.tCDTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 644);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHotSwap);
            this.Controls.Add(this.btnDesktop);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnWallMount);
            this.Controls.Add(this.btnCIM);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "TCD List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCD_ListDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TCD_ListDataSet tCD_ListDataSet;
        private System.Windows.Forms.BindingSource tCDBindingSource;
        private TCD_ListDataSetTableAdapters.TCDTableAdapter tCDTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCIM;
        private System.Windows.Forms.Button btnWallMount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDesktop;
        private System.Windows.Forms.Button btnHotSwap;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wallMountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desktopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotswapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACDataGridViewTextBoxColumn;
    }
}

