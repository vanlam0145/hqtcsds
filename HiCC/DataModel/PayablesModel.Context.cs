﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PayablesEntities : DbContext
    {
        public PayablesEntities()
            : base("name=PayablesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GLAccount> GLAccounts { get; set; }
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<DeleteLog> DeleteLogs { get; set; }
    }
}
