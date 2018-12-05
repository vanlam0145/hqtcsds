namespace HiCC
{
    partial class FrmFindVendor
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
            this.singleLineAddressListBox = new System.Windows.Forms.ListBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // singleLineAddressListBox
            // 
            this.singleLineAddressListBox.DataSource = this.vendorBindingSource;
            this.singleLineAddressListBox.DisplayMember = "SingleLineAddress";
            this.singleLineAddressListBox.FormattingEnabled = true;
            this.singleLineAddressListBox.Location = new System.Drawing.Point(41, 79);
            this.singleLineAddressListBox.Name = "singleLineAddressListBox";
            this.singleLineAddressListBox.Size = new System.Drawing.Size(723, 251);
            this.singleLineAddressListBox.TabIndex = 2;
            this.singleLineAddressListBox.ValueMember = "VendorID";
            this.singleLineAddressListBox.SelectedIndexChanged += new System.EventHandler(this.singleLineAddressListBox_SelectedIndexChanged);
            this.singleLineAddressListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.singleLineAddressListBox_MouseDoubleClick);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(DataModel.Vendor);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 32);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(484, 34);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(625, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(41, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(147, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(496, 359);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Message";
            // 
            // FrmFindVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.singleLineAddressListBox);
            this.Name = "FrmFindVendor";
            this.Text = "FindVendor";
            this.Load += new System.EventHandler(this.FrmFindVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.ListBox singleLineAddressListBox;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMessage;
    }
}