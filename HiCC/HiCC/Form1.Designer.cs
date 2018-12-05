namespace HiCC
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label stateNameLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label cityLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox1 = new System.Windows.Forms.TextBox();
            this.stateNameTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.BalanceDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGetVendorID = new System.Windows.Forms.Button();
            this.btnFindVendor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnaddvendor = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceLineItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(46, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(46, 84);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(48, 13);
            address1Label.TabIndex = 2;
            address1Label.Text = "Address:";
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Location = new System.Drawing.Point(37, 150);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(32, 13);
            stateNameLabel.TabIndex = 5;
            stateNameLabel.Text = "State";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(75, 150);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(25, 13);
            zipCodeLabel.TabIndex = 7;
            zipCodeLabel.Text = "Zip:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 150);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(24, 13);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(111, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(526, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(111, 77);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.ReadOnly = true;
            this.address1TextBox.Size = new System.Drawing.Size(526, 20);
            this.address1TextBox.TabIndex = 3;
            // 
            // address1TextBox1
            // 
            this.address1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Address1", true));
            this.address1TextBox1.Location = new System.Drawing.Point(111, 112);
            this.address1TextBox1.Name = "address1TextBox1";
            this.address1TextBox1.ReadOnly = true;
            this.address1TextBox1.Size = new System.Drawing.Size(526, 20);
            this.address1TextBox1.TabIndex = 5;
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "State.StateName", true));
            this.stateNameTextBox.Location = new System.Drawing.Point(292, 150);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.ReadOnly = true;
            this.stateNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.stateNameTextBox.TabIndex = 6;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(482, 150);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.ReadOnly = true;
            this.zipCodeTextBox.Size = new System.Drawing.Size(155, 20);
            this.zipCodeTextBox.TabIndex = 8;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(111, 12);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtVendorID.TabIndex = 9;
            this.txtVendorID.TextChanged += new System.EventHandler(this.btnVendorID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(111, 147);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(158, 20);
            this.cityTextBox.TabIndex = 12;
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.AutoGenerateColumns = false;
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.BalanceDue,
            this.info});
            this.invoicesDataGridView.DataSource = this.invoicesBindingSource;
            this.invoicesDataGridView.Location = new System.Drawing.Point(27, 187);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.Size = new System.Drawing.Size(814, 220);
            this.invoicesDataGridView.TabIndex = 13;
            this.invoicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicesDataGridView_CellContentClick);
            // 
            // BalanceDue
            // 
            this.BalanceDue.DataPropertyName = "BalanceDue";
            this.BalanceDue.HeaderText = "BalanceDue";
            this.BalanceDue.Name = "BalanceDue";
            this.BalanceDue.ReadOnly = true;
            // 
            // info
            // 
            this.info.HeaderText = "";
            this.info.Name = "info";
            this.info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.info.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.info.Text = "More detail";
            this.info.UseColumnTextForButtonValue = true;
            // 
            // btnGetVendorID
            // 
            this.btnGetVendorID.Location = new System.Drawing.Point(239, 8);
            this.btnGetVendorID.Name = "btnGetVendorID";
            this.btnGetVendorID.Size = new System.Drawing.Size(75, 23);
            this.btnGetVendorID.TabIndex = 14;
            this.btnGetVendorID.Text = "Get vendor";
            this.btnGetVendorID.UseVisualStyleBackColor = true;
            this.btnGetVendorID.Click += new System.EventHandler(this.btnGetVendorID_Click);
            // 
            // btnFindVendor
            // 
            this.btnFindVendor.Location = new System.Drawing.Point(320, 10);
            this.btnFindVendor.Name = "btnFindVendor";
            this.btnFindVendor.Size = new System.Drawing.Size(75, 23);
            this.btnFindVendor.TabIndex = 15;
            this.btnFindVendor.Text = "Find Vendor";
            this.btnFindVendor.UseVisualStyleBackColor = true;
            this.btnFindVendor.Click += new System.EventHandler(this.btnFindVendor_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add Invoice";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnaddvendor
            // 
            this.btnaddvendor.Location = new System.Drawing.Point(662, 45);
            this.btnaddvendor.Name = "btnaddvendor";
            this.btnaddvendor.Size = new System.Drawing.Size(75, 23);
            this.btnaddvendor.TabIndex = 17;
            this.btnaddvendor.Text = "Add Vendor";
            this.btnaddvendor.UseVisualStyleBackColor = true;
            this.btnaddvendor.Click += new System.EventHandler(this.btnaddvendor_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(662, 74);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify Vendor";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(662, 148);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 20;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "InvoiceNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "InvoiceDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InvoiceTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "InvoiceTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "PaymentTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreditTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreditTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.vendorBindingSource;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(DataModel.Vendor);
            // 
            // invoiceLineItemsBindingSource
            // 
            this.invoiceLineItemsBindingSource.DataMember = "InvoiceLineItems";
            this.invoiceLineItemsBindingSource.DataSource = this.invoicesBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 465);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnaddvendor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFindVendor);
            this.Controls.Add(this.btnGetVendorID);
            this.Controls.Add(this.invoicesDataGridView);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(stateNameLabel);
            this.Controls.Add(this.stateNameTextBox);
            this.Controls.Add(this.address1TextBox1);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Vendor Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.BindingSource invoiceLineItemsBindingSource;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address1TextBox1;
        private System.Windows.Forms.TextBox stateNameTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DataGridView invoicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceDue;
        private System.Windows.Forms.DataGridViewButtonColumn info;
        private System.Windows.Forms.Button btnGetVendorID;
        private System.Windows.Forms.Button btnFindVendor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnaddvendor;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
    }
}

