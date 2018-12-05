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
using System.Data.Entity.Core;
using DataModel;
namespace HiCC
{
    public partial class Line_Items : Form
    {
        public Line_Items()
        {
            InitializeComponent();
        }
        public Line_Items(Invoice invoice)
        {
            InitializeComponent();
            txtvendor.Text = invoice.Vendor.Name;
            txtinvoiceno.Text = invoice.InvoiceNumber;
            invoiceLineItemsDataGridView.DataSource =                invoice.InvoiceLineItems.ToList();
        }
        private void Line_Items_Load(object sender, EventArgs e)
        {

        }

        private void invoiceLineItemsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var lineItem = (InvoiceLineItem)row.DataBoundItem;
                    row.Cells[dataGridViewTextBoxColumn4.Index].Value =
                    lineItem.GLAccount.Description;
                }
            }
        }
    }
}
