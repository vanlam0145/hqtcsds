using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public partial class Invoice
    {
        public decimal BalanceDue
        {
            get
            {
                return InvoiceTotal - PaymentTotal - CreditTotal;
            }
        }
    }
}
