namespace HiCC
{
    partial class frmAddInvoice
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label invoiceNumberLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label descriptionLabel2;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label invoiceTotalLabel;
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.termComboBox = new System.Windows.Forms.ComboBox();
            this.accountComboBox1 = new System.Windows.Forms.ComboBox();
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.invoiceTotalTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            invoiceNumberLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            invoiceTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(DataModel.Invoice);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(19, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Vendor:";
            // 
            // txtVendor
            // 
            this.txtVendor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Vendor.Name", true));
            this.txtVendor.Location = new System.Drawing.Point(110, 12);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(100, 20);
            this.txtVendor.TabIndex = 1;
            // 
            // invoiceNumberLabel
            // 
            invoiceNumberLabel.AutoSize = true;
            invoiceNumberLabel.Location = new System.Drawing.Point(19, 51);
            invoiceNumberLabel.Name = "invoiceNumberLabel";
            invoiceNumberLabel.Size = new System.Drawing.Size(85, 13);
            invoiceNumberLabel.TabIndex = 2;
            invoiceNumberLabel.Text = "Invoice Number:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceNumber", true));
            this.txtInvoiceNumber.Location = new System.Drawing.Point(110, 48);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceNumber.TabIndex = 3;
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(19, 99);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(71, 13);
            invoiceDateLabel.TabIndex = 4;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(110, 93);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.invoiceDateDateTimePicker.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(19, 132);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(30, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "term:";
            // 
            // termComboBox
            // 
            this.termComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Term.Description", true));
            this.termComboBox.FormattingEnabled = true;
            this.termComboBox.Location = new System.Drawing.Point(110, 132);
            this.termComboBox.Name = "termComboBox";
            this.termComboBox.Size = new System.Drawing.Size(121, 21);
            this.termComboBox.TabIndex = 7;
            // 
            // accountComboBox1
            // 
            this.accountComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Vendor.GLAccount.Description", true));
            this.accountComboBox1.FormattingEnabled = true;
            this.accountComboBox1.Location = new System.Drawing.Point(110, 172);
            this.accountComboBox1.Name = "accountComboBox1";
            this.accountComboBox1.Size = new System.Drawing.Size(121, 21);
            this.accountComboBox1.TabIndex = 9;
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(19, 175);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(50, 13);
            descriptionLabel1.TabIndex = 8;
            descriptionLabel1.Text = "Account:";
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.invoiceBindingSource;
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
            this.invoiceLineItemsDataGridView.Location = new System.Drawing.Point(12, 199);
            this.invoiceLineItemsDataGridView.Name = "invoiceLineItemsDataGridView";
            this.invoiceLineItemsDataGridView.Size = new System.Drawing.Size(728, 220);
            this.invoiceLineItemsDataGridView.TabIndex = 10;
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
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Location = new System.Drawing.Point(266, 175);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(63, 13);
            descriptionLabel2.TabIndex = 11;
            descriptionLabel2.Text = "Description:";
            // 
            // txtdescription
            // 
            this.txtdescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemsBindingSource, "Description", true));
            this.txtdescription.Location = new System.Drawing.Point(345, 172);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(100, 20);
            this.txtdescription.TabIndex = 12;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(468, 175);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 13;
            amountLabel.Text = "Amount:";
            // 
            // txtamount
            // 
            this.txtamount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemsBindingSource, "Amount", true));
            this.txtamount.Location = new System.Drawing.Point(535, 172);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 14;
            // 
            // invoiceTotalLabel
            // 
            invoiceTotalLabel.AutoSize = true;
            invoiceTotalLabel.Location = new System.Drawing.Point(562, 428);
            invoiceTotalLabel.Name = "invoiceTotalLabel";
            invoiceTotalLabel.Size = new System.Drawing.Size(72, 13);
            invoiceTotalLabel.TabIndex = 15;
            invoiceTotalLabel.Text = "Invoice Total:";
            // 
            // invoiceTotalTextBox
            // 
            this.invoiceTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceTotal", true));
            this.invoiceTotalTextBox.Location = new System.Drawing.Point(640, 425);
            this.invoiceTotalTextBox.Name = "invoiceTotalTextBox";
            this.invoiceTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceTotalTextBox.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(665, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Invoice";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(664, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel Invoice";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(invoiceTotalLabel);
            this.Controls.Add(this.invoiceTotalTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(descriptionLabel2);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.invoiceLineItemsDataGridView);
            this.Controls.Add(descriptionLabel1);
            this.Controls.Add(this.accountComboBox1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.termComboBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(invoiceNumberLabel);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtVendor);
            this.Name = "frmAddInvoice";
            this.Text = "frmAddInvoice";
            this.Load += new System.EventHandler(this.frmAddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.ComboBox termComboBox;
        private System.Windows.Forms.ComboBox accountComboBox1;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private System.Windows.Forms.DataGridView invoiceLineItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox invoiceTotalTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}