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
using System.Data.Entity;
using System.Data.Entity.Core;

namespace HiCC
{
    public partial class frmAddInvoice : Form
    {
        private Vendor _vendor;
        private bool addVendor;
        private PayablesEntities _context;
        private Invoice invoice;
        public frmAddInvoice()
        {
            InitializeComponent();
        }
        public frmAddInvoice(PayablesEntities context)
        {
            InitializeComponent();
            this._context = context;
            addVendor = true;
        }
        public frmAddInvoice(PayablesEntities context, Vendor vendor)
        {// updating passed vendor
            InitializeComponent();
            this._vendor = vendor;
            this._context = context;
            addVendor = false;
        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            txtVendor.Text = _vendor.Name;
            termComboBox.DataSource = _context.Terms.OrderBy(
            t => t.TermsID).ToList();
            termComboBox.DisplayMember = "Description";
            termComboBox.ValueMember = "TermsID";
            termComboBox.SelectedValue = _vendor.Term.TermsID;
            accountComboBox1.DataSource = _context.GLAccounts.OrderBy(
            a => a.Description).ToList();
            accountComboBox1.DisplayMember = "Description";
            accountComboBox1.ValueMember = "AccountNo";
            accountComboBox1.SelectedValue = _vendor.GLAccount.AccountNo;
            invoice = new Invoice();
            invoiceLineItemsBindingSource.DataSource =
            invoice.InvoiceLineItems.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InvoiceLineItem item = new InvoiceLineItem();
            item.GLAccount = (GLAccount)accountComboBox1.SelectedItem;
            item.Description = txtdescription.Text;
            item.Amount = Convert.ToDecimal(txtamount.Text);
            invoice.InvoiceLineItems.Add(item);
            invoice.InvoiceTotal += item.Amount;
            invoiceLineItemsBindingSource.DataSource =
            invoice.InvoiceLineItems.ToList();
            invoiceTotalTextBox.Text = invoice.InvoiceTotal.ToString("c");
            accountComboBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (invoice.InvoiceLineItems.Count == 0)
            {
                MessageBox.Show("You must add at least one line item.",
                "Entry Error");
                accountComboBox1.Focus();
            }
            else
            {
                invoice.InvoiceNumber = txtInvoiceNumber.Text;
                invoice.Term = (Term)termComboBox.SelectedItem;
                invoice.InvoiceDate = invoiceDateDateTimePicker.Value;
                invoice.DueDate = invoice.InvoiceDate.AddDays(invoice.Term.DueDays);
                short sequence_no = 1;
                foreach (InvoiceLineItem item in invoice.InvoiceLineItems)
                {
                    item.InvoiceSequence = sequence_no++;
                }
                _vendor.Invoices.Add(invoice);
                try
                {
                    _context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
        }
    }
}
