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
    public partial class fmFVendor : Form
    {
        private PayablesEntities _context;
        private List<Vendor> vendorList;
        public Vendor vendor;

        public fmFVendor()
        {
            InitializeComponent();
        }

        private void fmFVendor_Load(object sender, EventArgs e)
        {
            _context = new PayablesEntities();
        }

        private void singleLineAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                vendorList = _context.Vendors.Where(v => v.Name.Contains(txtName.Text.Trim())&& v.State1.StateName.Contains(txtState.Text.Trim())).ToList();
                singleLineAddressListBox.DataSource = vendorList;
                switch(vendorList.Count)
                {
                    case 0:
                        lbMessage.Text = "No vendors found with that name" + "and state";
                        break;
                    case 1:
                        lbMessage.Text = "one cendor found with that name" + "and state";
                        break;
                    default:
                        lbMessage.Text = vendorList.Count + "vendor found with that name and state.";
                        break;
                }
                singleLineAddressListBox.SelectedIndex = -1;
                btnOk.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(singleLineAddressListBox.SelectedIndex != -1)
            {
                vendor = vendorList[singleLineAddressListBox.SelectedIndex];
                this.DialogResult = DialogResult.OK;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }
    }
}
