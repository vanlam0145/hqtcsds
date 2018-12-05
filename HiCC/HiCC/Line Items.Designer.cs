namespace HiCC
{
    partial class Line_Items
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
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtvendor = new System.Windows.Forms.TextBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(DataModel.Vendor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor";
            // 
            // txtvendor
            // 
            this.txtvendor.Location = new System.Drawing.Point(103, 40);
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Size = new System.Drawing.Size(242, 20);
            this.txtvendor.TabIndex = 1;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(103, 75);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(100, 20);
            this.txtinvoiceno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "InvoiceNo";
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataSource = typeof(DataModel.ObservableListSource<DataModel.InvoiceLineItem>);
            // 
            // invoiceLineItemsDataGridView
            // 
            this.invoiceLineItemsDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.invoiceLineItemsDataGridView.DataSource = this.invoiceLineItemsBindingSource;
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(44, 138);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(433, 220);
            this.invoiceLineItemsDataGridView.TabIndex = 4;
            this.invoiceLineItemsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.invoiceLineItemsDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GLAccount";
            this.dataGridViewTextBoxColumn5.HeaderText = "GLAccount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Line_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 457);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(this.txtinvoiceno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvendor);
            this.Controls.Add(this.label1);
            this.Name = "Line_Items";
            this.Text = "Line_Items";
            this.Load += new System.EventHandler(this.Line_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvendor;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}