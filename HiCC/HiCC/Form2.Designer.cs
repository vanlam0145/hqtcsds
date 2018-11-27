namespace HiCC
{
    partial class fmFVendor
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
            System.Windows.Forms.Label singleLineAddressLabel;
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.singleLineAddressListBox = new System.Windows.Forms.ListBox();
            this.vendorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbMessage = new System.Windows.Forms.Label();
            singleLineAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(DataModel.Vendor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "State:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(321, 31);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(455, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(51, 351);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // singleLineAddressLabel
            // 
            singleLineAddressLabel.AutoSize = true;
            singleLineAddressLabel.Location = new System.Drawing.Point(89, 74);
            singleLineAddressLabel.Name = "singleLineAddressLabel";
            singleLineAddressLabel.Size = new System.Drawing.Size(103, 13);
            singleLineAddressLabel.TabIndex = 7;
            singleLineAddressLabel.Text = "Single Line Address:";
            singleLineAddressLabel.Click += new System.EventHandler(this.singleLineAddressLabel_Click);
            // 
            // singleLineAddressListBox
            // 
            this.singleLineAddressListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorBindingSource, "SingleLineAddress", true));
            this.singleLineAddressListBox.FormattingEnabled = true;
            this.singleLineAddressListBox.Location = new System.Drawing.Point(92, 90);
            this.singleLineAddressListBox.Name = "singleLineAddressListBox";
            this.singleLineAddressListBox.Size = new System.Drawing.Size(392, 238);
            this.singleLineAddressListBox.TabIndex = 8;
            // 
            // vendorBindingSource1
            // 
            this.vendorBindingSource1.DataSource = typeof(DataModel.Vendor);
            // 
            // vendorBindingSource2
            // 
            this.vendorBindingSource2.DataSource = typeof(DataModel.Vendor);
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.vendorBindingSource;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(221, 74);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(35, 13);
            this.lbMessage.TabIndex = 9;
            this.lbMessage.Text = "label3";
            // 
            // fmFVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 394);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(singleLineAddressLabel);
            this.Controls.Add(this.singleLineAddressListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmFVendor";
            this.Text = "Find Vendor";
            this.Load += new System.EventHandler(this.fmFVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox singleLineAddressListBox;
        private System.Windows.Forms.BindingSource vendorBindingSource1;
        private System.Windows.Forms.BindingSource vendorBindingSource2;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.Label lbMessage;
    }
}