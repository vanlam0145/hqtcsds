using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
namespace HiCC
{
    public partial class AddModifyVendor : Form
    {
        public Vendor vendor;
        private bool addVendor;
        private PayablesEntities _context;
        public AddModifyVendor()
        {
            InitializeComponent();
        }
        public AddModifyVendor( PayablesEntities context)
        {// adding new vendor
            InitializeComponent();
            this._context = context;
            addVendor = true;
        }
        public AddModifyVendor(PayablesEntities context, Vendor vendor)
        {// updating passed vendor
            InitializeComponent();
            this.vendor = vendor;
            this._context = context;
            addVendor = false;
        }
        private void AddModifyVendor_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            if(addVendor)
            {
                this.Text = "Add Vendor";
                cbostateName.SelectedIndex = -1;
                cboTerms.SelectedIndex = -1;
                cboAcc.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Vendor";
                DisplayVendorData();
            }
        }
        public void DisplayVendorData()
        {
            txtName.Text = vendor.Name;
            txtAddress1.Text = vendor.Address1;
            txtAddress2.Text = vendor.Address2;
            txtCity.Text = vendor.City;
            cbostateName.SelectedValue = vendor.State.StateCode;
            txtZip.Text = vendor.ZipCode;
            cboTerms.SelectedValue = vendor.Term.TermsID;
            cboAcc.SelectedValue = vendor.GLAccount.AccountNo;
            if (vendor.Phone == null || vendor.Phone == "")
                txtPhone.Text = "";
            else
                txtPhone.Text = vendor.Phone;
            txtContactFname.Text = vendor.ContactFName;
            label.Text = vendor.ContactFName;
        }
        private void LoadComboBoxes()
        {
            try
            {
                cbostateName.DataSource =
                    _context.States.OrderBy(State => State.StateName).ToList();
                cbostateName.DisplayMember = "StateName";
                cbostateName.ValueMember = "StateCode";

                cboTerms.DataSource = _context.Terms.ToList();
                cboTerms.DisplayMember = "Description";
                cboTerms.ValueMember = "TermsID";

                cboAcc.DataSource = _context.GLAccounts.ToList();
                cboAcc.DisplayMember = "Description";
                cboAcc.ValueMember = "AccountNo";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void PutVendorData()
        {
            vendor.Name = txtName.Text;
            vendor.Address1 = txtAddress1.Text;
            vendor.Address2 = txtAddress2.Text;
            vendor.City = txtCity.Text;
            vendor.State = (State)cbostateName.SelectedItem;
            vendor.ZipCode = txtZip.Text;
            vendor.Term = (Term)cboTerms.SelectedItem;
            vendor.GLAccount = (GLAccount)cboAcc.SelectedItem;
            vendor.Phone = txtPhone.Text.Replace(".", "");
            vendor.ContactFName = txtContactFname.Text;
            vendor.ContactLName = label.Text;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(addVendor)
            {
                vendor = new Vendor();
            }
            PutVendorData();
            this.DialogResult = DialogResult.OK;
        }
    }
}
