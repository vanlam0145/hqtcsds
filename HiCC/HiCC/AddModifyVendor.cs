using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataModel;
namespace HiCC
{
    public partial class AddModifyVendor : Form
    {
        public Vendor vendor;
        private bool addVendor;
        private PayablesEntities _context; 
        public AddModifyVendor(PayablesEntities context)
        {
            InitializeComponent();
            _context = context;
            addVendor = true;
        }
        public AddModifyVendor(PayablesEntities context,Vendor vendor)
        {
            InitializeComponent();
            this.vendor = vendor;
            _context = context;
            addVendor = false;
        }
        private void LoadComboBox()
        {
            try
            {
                cmbState.DataSource = _context.States.OrderBy(state => state.StateName).ToList();
                cmbState.DisplayMember = "StateName";
                cmbState.ValueMember = "SateCode";

                cmbTems.DataSource = _context.Terms.ToList();
                cmbTems.DisplayMember = "Description";
                cmbTems.ValueMember = "termsID";

                cmbAccount.DataSource = _context.GLAccounts.ToList();
                cmbAccount.DisplayMember = "description";
                cmbAccount.ValueMember = "accountNo";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddModifyVendor_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            if(addVendor)
            {
                Text = "add vendor";
                cmbState.SelectedIndex = -1;
                cmbTems.SelectedIndex = -1;
                cmbAccount.SelectedIndex = -1;
            }
            else
            {
                Text = "Modify vendor"; 
                DisplayVendorData();
            }
        }
        private void DisplayVendorData()
        {
            txtName.Text = vendor.Name;
            txtAddress.Text = vendor.Address1;
            txtAddress2.Text = vendor.Address2;
            txtCity.Text = vendor.City;
            cmbState.SelectedValue = vendor.State1.StateCode;
            txtZip.Text = vendor.ZipCode;
            cmbTems.SelectedValue = vendor.Term.TermsID;
            cmbAccount.SelectedValue = vendor.GLAccount.AccountNo;
            if (vendor.Phone == null || vendor.Phone == "")
                txtphone.Text = "";
            else
                txtphone.Text = vendor.Phone;
            txtContactFname.Text = vendor.ContactFName;
            txtContactLName.Text = vendor.ContactLName;
        }
        private void  PutVendorData()
        {
            vendor.Name = txtName.Text;
            vendor.Address1 = txtAddress.Text;
            vendor.Address2 = txtAddress2.Text;
            vendor.City = txtCity.Text;
            vendor.State1 =(State)cmbState.SelectedItem;
            vendor.ZipCode = txtZip.Text;
            vendor.Term = (Term)cmbTems.SelectedItem;
            vendor.GLAccount = (GLAccount)cmbAccount.SelectedItem;
            vendor.Phone = txtphone.Text;
            vendor.ContactFName = txtContactFname.Text;
            vendor.ContactLName = txtContactLName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addVendor)
                vendor = new Vendor();
            PutVendorData();
            DialogResult = DialogResult.OK;
        }
    }
}
