// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // BatchInvoice
    public class BatchInvoice
    {
        public Guid Id { get; set; } // PrimaryKey (Primary key)

        // Reverse navigation

        /// <summary>
        /// Child BatchInvoiceItems where [BatchInvoiceItem].[BatchInvoiceId] point to this entity (FK_dbo.BatchInvoiceItem_dbo.BatchInvoice_BatchInvoiceId)
        /// </summary>
        public ICollection<BatchInvoiceItem> Invoices { get; set; } // BatchInvoiceItem.FK_dbo.BatchInvoiceItem_dbo.BatchInvoice_BatchInvoiceId
        
        public BatchInvoice()
        {
            Invoices = new List<BatchInvoiceItem>();
        }
    }

}
// </auto-generated>