namespace COTGPetshop.PosApp
{
    partial class PosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.animalsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesHistory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbGrossTotal = new System.Windows.Forms.Label();
            this.txtGrossTotal = new System.Windows.Forms.Label();
            this.lbNetTotal = new System.Windows.Forms.Label();
            this.txtNetTotal = new System.Windows.Forms.Label();
            this.lbLegTotal = new System.Windows.Forms.Label();
            this.lbVatTotal = new System.Windows.Forms.Label();
            this.txtLegTotal = new System.Windows.Forms.Label();
            this.txtVatTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalsGridView
            // 
            this.animalsGridView.AutoGenerateColumns = false;
            this.animalsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.animalsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.animalsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.animalsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.grossPriceDataGridViewTextBoxColumn,
            this.Sell});
            this.animalsGridView.DataMember = "Products";
            this.animalsGridView.DataSource = this.modelBindingSource;
            this.animalsGridView.Location = new System.Drawing.Point(43, 47);
            this.animalsGridView.MultiSelect = false;
            this.animalsGridView.Name = "animalsGridView";
            this.animalsGridView.ReadOnly = true;
            this.animalsGridView.RowHeadersVisible = false;
            this.animalsGridView.Size = new System.Drawing.Size(428, 150);
            this.animalsGridView.TabIndex = 0;
            this.animalsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalsGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossPriceDataGridViewTextBoxColumn
            // 
            this.grossPriceDataGridViewTextBoxColumn.DataPropertyName = "GrossPrice";
            this.grossPriceDataGridViewTextBoxColumn.HeaderText = "GrossPrice";
            this.grossPriceDataGridViewTextBoxColumn.Name = "grossPriceDataGridViewTextBoxColumn";
            this.grossPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sell
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Sell.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sell.HeaderText = "";
            this.Sell.Name = "Sell";
            this.Sell.ReadOnly = true;
            this.Sell.Text = "Sell";
            this.Sell.UseColumnTextForButtonValue = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(COTGPetshop.PosApp.POSModel);
            // 
            // salesHistory
            // 
            this.salesHistory.Location = new System.Drawing.Point(552, 47);
            this.salesHistory.Multiline = true;
            this.salesHistory.Name = "salesHistory";
            this.salesHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesHistory.Size = new System.Drawing.Size(252, 230);
            this.salesHistory.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbGrossTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGrossTotal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNetTotal, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNetTotal, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbLegTotal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbVatTotal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLegTotal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVatTotal, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 328);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbGrossTotal
            // 
            this.lbGrossTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGrossTotal.AutoSize = true;
            this.lbGrossTotal.Location = new System.Drawing.Point(65, 18);
            this.lbGrossTotal.Name = "lbGrossTotal";
            this.lbGrossTotal.Size = new System.Drawing.Size(60, 13);
            this.lbGrossTotal.TabIndex = 0;
            this.lbGrossTotal.Text = "Sales Total";
            // 
            // txtGrossTotal
            // 
            this.txtGrossTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrossTotal.AutoSize = true;
            this.txtGrossTotal.Location = new System.Drawing.Point(78, 68);
            this.txtGrossTotal.Name = "txtGrossTotal";
            this.txtGrossTotal.Size = new System.Drawing.Size(34, 13);
            this.txtGrossTotal.TabIndex = 2;
            this.txtGrossTotal.Text = "£0.00";
            // 
            // lbNetTotal
            // 
            this.lbNetTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNetTotal.AutoSize = true;
            this.lbNetTotal.Location = new System.Drawing.Point(640, 18);
            this.lbNetTotal.Name = "lbNetTotal";
            this.lbNetTotal.Size = new System.Drawing.Size(51, 13);
            this.lbNetTotal.TabIndex = 5;
            this.lbNetTotal.Text = "Net Total";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNetTotal.AutoSize = true;
            this.txtNetTotal.Location = new System.Drawing.Point(648, 68);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(34, 13);
            this.txtNetTotal.TabIndex = 8;
            this.txtNetTotal.Text = "£0.00";
            // 
            // lbLegTotal
            // 
            this.lbLegTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLegTotal.AutoSize = true;
            this.lbLegTotal.Location = new System.Drawing.Point(452, 18);
            this.lbLegTotal.Name = "lbLegTotal";
            this.lbLegTotal.Size = new System.Drawing.Size(46, 13);
            this.lbLegTotal.TabIndex = 3;
            this.lbLegTotal.Text = "Leg Tax";
            // 
            // lbVatTotal
            // 
            this.lbVatTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVatTotal.AutoSize = true;
            this.lbVatTotal.Location = new System.Drawing.Point(257, 18);
            this.lbVatTotal.Name = "lbVatTotal";
            this.lbVatTotal.Size = new System.Drawing.Size(55, 13);
            this.lbVatTotal.TabIndex = 4;
            this.lbVatTotal.Text = "VAT Total";
            // 
            // txtLegTotal
            // 
            this.txtLegTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLegTotal.AutoSize = true;
            this.txtLegTotal.Location = new System.Drawing.Point(458, 68);
            this.txtLegTotal.Name = "txtLegTotal";
            this.txtLegTotal.Size = new System.Drawing.Size(34, 13);
            this.txtLegTotal.TabIndex = 6;
            this.txtLegTotal.Text = "£0.00";
            // 
            // txtVatTotal
            // 
            this.txtVatTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVatTotal.AutoSize = true;
            this.txtVatTotal.Location = new System.Drawing.Point(268, 68);
            this.txtVatTotal.Name = "txtVatTotal";
            this.txtVatTotal.Size = new System.Drawing.Size(34, 13);
            this.txtVatTotal.TabIndex = 7;
            this.txtVatTotal.Text = "£0.00";
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 476);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.salesHistory);
            this.Controls.Add(this.animalsGridView);
            this.Name = "PosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView animalsGridView;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Sell;
        private System.Windows.Forms.TextBox salesHistory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbGrossTotal;
        private System.Windows.Forms.Label txtGrossTotal;
        private System.Windows.Forms.Label lbLegTotal;
        private System.Windows.Forms.Label lbVatTotal;
        private System.Windows.Forms.Label lbNetTotal;
        private System.Windows.Forms.Label txtLegTotal;
        private System.Windows.Forms.Label txtVatTotal;
        private System.Windows.Forms.Label txtNetTotal;
    }
}

