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
using System.Data.Entity.Core;

namespace HiCC
{
    public partial class Form1 : Form
    {
        private Vendor _vendor;
        private PayablesEntities _context;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._context = new PayablesEntities();
        }

        private void btnVendorID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGetVendorID_Click(object sender, EventArgs e)
        {
            int vendorID = Convert.ToInt32(txtVendorID.Text);
            if (_context != null) _context.Dispose();
            _context = new PayablesEntities();
            try
            {
                _vendor = _context.Vendors.Where(v => v.VendorID == vendorID).Include("Invoices").SingleOrDefault();
                vendorBindingSource.DataSource = _context.Vendors.Local.ToBindingList();
                invoicesDataGridView.Refresh();
                
                if(_vendor==null)
                {
                    MessageBox.Show("No valid vendor found with this ID", "Vendor not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }


        }

        private void btnFindVendor_Click(object sender, EventArgs e)
        {
            using (FrmFindVendor findVendorForm = new FrmFindVendor())
            {
                
                DialogResult res = findVendorForm.ShowDialog();
                if(res==DialogResult.OK)
                {
                    try
                    {
                        if (_context != null) _context.Dispose();
                        _context = new PayablesEntities();
                        _vendor = findVendorForm.vendor;
                        txtVendorID.Text = _vendor.VendorID.ToString();

                        _context.Vendors.Attach(_vendor); // vì bên form kia đã load lên từ cơ sở dữ liệu rồi nên không cần load lên lại mà xài lệnh này để sử dụng cái có sẵn luôn
                        _context.Entry(_vendor).Collection(v => v.Invoices).Load();
                        vendorBindingSource.DataSource = _context.Vendors.Local.ToBindingList();
                        invoicesDataGridView.Refresh();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(_vendor==null)
            {
                MessageBox.Show("Vendor must be specified", "Entry Error");
            }
            else
            {
                using (AddModifyVendor addModifyVendorForm = new AddModifyVendor(_context, _vendor))
                {
                    DialogResult res = addModifyVendorForm.ShowDialog();
                    if(res==DialogResult.OK)
                    {
                        try
                        {
                            _context.SaveChanges();
                        }
                        catch(OptimisticConcurrencyException)
                        {
                            _context.Entry(_vendor).Reload();
                            if(_context.Entry(_vendor).State==EntityState.Detached)
                            {
                                MessageBox.Show("Vendor has been deleted by another user", "Cuncurrency Error");
                                txtVendorID.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Vendor has been updated by another user", "Cuncurrency Error");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
           try
            {
                foreach (Invoice inv in _vendor.Invoices)
                {
                    _context.InvoiceLineItems.RemoveRange(inv.InvoiceLineItems);
                }
                _context.Invoices.RemoveRange(_vendor.Invoices);
                _context.Vendors.Remove(_vendor);
                _context.SaveChanges();
                //_context.Entry(_vendor).Reload();
                //invoicesDataGridView.Refresh();
                _vendor = null;
                txtVendorID.Text = "";
                txtVendorID.Focus();
            }
            catch(Exception ex)
            {
                
            }
        }
        private void xoa2()
        {
            //using (transc)
        }

        private void btnaddvendor_Click(object sender, EventArgs e)
        {
            using (AddModifyVendor addModifyVendorForm =
        new AddModifyVendor(_context))
            {
                DialogResult res = addModifyVendorForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                    _vendor = addModifyVendorForm.vendor;
                        txtVendorID.Text = _vendor.VendorID.ToString();
                        if (_context != null) _context.Dispose();
                        _context = new PayablesEntities();
                        _context.Vendors.Add(_vendor);
                        _context.SaveChanges();
                        vendorBindingSource.DataSource =
                        _context.Vendors.Local.ToBindingList();
                        invoicesDataGridView.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_vendor == null)
            {
                MessageBox.Show("Vendor must be specified", "Entry Error");
                return;
            }
            using (frmAddInvoice addInvoiceForm =
            new frmAddInvoice(_context, _vendor))
            {
                DialogResult res = addInvoiceForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    invoicesDataGridView.Refresh();
                }
            }
        }

        private void invoicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                int i = e.RowIndex;
                DataGridViewRow row = invoicesDataGridView.Rows[i];
                Invoice invoice = (Invoice)row.DataBoundItem;
                using (Line_Items lineItemsForm = new Line_Items(invoice))
                {
                    lineItemsForm.ShowDialog();
                }
            }
        }
    }
}
