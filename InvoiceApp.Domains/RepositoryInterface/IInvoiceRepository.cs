using InvoiceApp.Core;
using InvoiceApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public interface IInvoiceRepository:IBaseRepository<Invoice> 
    {



        Task<IEnumerable<Invoice>> GetByDate(DateTime date);

        InvoiceDBContext InvoiceContext { get; }
    }
}
