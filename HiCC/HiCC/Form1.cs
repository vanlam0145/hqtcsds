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
using System.Data.Entity.Core;
namespace HiCC
{
    public partial class Form1 : Form
    {
        private PayablesEntities _context;
        private Vendor _vendor;
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetVenDor_Click(object sender, EventArgs e)
        {
            int vendorID = Convert.ToInt32(vendorIDTextBox.Text);
            if (_context != null) _context.Dispose();
            _context = new PayablesEntities();
            try
            {
                _vendor = _context.Vendors.Where(v => v.VendorID == vendorID).Include("Invoices").SingleOrDefault();
                vendorBindingSource.DataSource = _context.Vendors.Local.ToBindingList();
                invoicesDataGridView.Refresh();

                if (_vendor == null)
                    MessageBox.Show("No valid vendor found with this ID", "vendor nor found");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFVendor_Click(object sender, EventArgs e)
        {
            fmFVendor fvd = new fmFVendor();
            fvd.ShowDialog();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if(_vendor==null)
            {
                MessageBox.Show("vendor must be specified", "entry Error");

            }
            else
            {
                using (AddModifyVendor addmodifyvendorform = new AddModifyVendor(_context, _vendor))
                {
                    DialogResult res = addmodifyvendorform.ShowDialog();
                    if(res==DialogResult.OK)
                    {
                        try
                        {
                            _context.SaveChanges();
                        }
                        catch(OptimisticConcurrencyException)
                        {
                            _context.Entry(_vendor).Reload();
                            if (_context.Entry(_vendor).State==EntityState.Detached)
                            {
                                MessageBox.Show("vendor has been deleted by another user", "cuncurrency error");
                                vendorIDTextBox.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("vendor has been update by another user", "cuncurrency error");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                        vendorBindingSource.ResetBindings(false);
                    }
                }
                    
            }
        }
    }
}
