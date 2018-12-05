using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using System.Data.Entity;
using System.Collections.Generic;
namespace HiCC
{
    public partial class FrmFindVendor : Form
    {
        private PayablesEntities _context;
        private List<Vendor> VendorList;
        public Vendor vendor;
        public FrmFindVendor()
        {
            InitializeComponent();
        }

        private void FrmFindVendor_Load(object sender, EventArgs e)
        {
            _context = new PayablesEntities();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                VendorList = _context.Vendors.Where(
                    v => v.Name.Contains(txtLastName.Text.Trim()) &&
                        v.State.StateName.Contains(txtState.Text.Trim())).ToList();
                singleLineAddressListBox.DataSource = VendorList;
                switch(VendorList.Count)
                {
                    case 0:
                        lblMessage.Text = "No vendors found with that name" + "and state";
                        break;
                    case 1:
                        lblMessage.Text = "One vendor found with that name" + "and State";
                        break;
                    default:
                        lblMessage.Text = VendorList.Count +
                            "Vendors found with that name and state ";
                        break;
                }
                singleLineAddressListBox.SelectedIndex = -1;
                btnOK.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (singleLineAddressListBox.SelectedIndex!=-1)
            {
                vendor = VendorList[singleLineAddressListBox.SelectedIndex];
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No vendor selected", "Entry error");
            }
        }

        private void singleLineAddressListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vendor = VendorList[singleLineAddressListBox.SelectedIndex];
            this.DialogResult = DialogResult.OK;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }

        private void singleLineAddressListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = true;
        }
    }
}
