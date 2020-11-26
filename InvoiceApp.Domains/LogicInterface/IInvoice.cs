using InvoiceApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public interface IInvoice
    {
        Task<int> SaveInvoice(Invoice data);

        Task<IEnumerable<Invoice>> GetAllInvoices();

        Task<Invoice> GetInvoiceById(int id);

        Task<IEnumerable<Invoice>> GetAllInvoicesByCreationDate(DateTime date);


    }
}
