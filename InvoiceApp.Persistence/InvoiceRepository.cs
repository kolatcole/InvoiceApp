using InvoiceApp.Core;
using InvoiceApp.Core.Model;
using InvoiceApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Persistence
{
    public class InvoiceRepository:BaseRepository<Invoice>, IInvoiceRepository
    {

        public InvoiceRepository(InvoiceDBContext context):base(context)
        {

        }

        

        public InvoiceDBContext InvoiceContext
        {
            get { return _context as InvoiceDBContext; }
        }

        public async Task<IEnumerable<Invoice>> GetByDate(DateTime date)
        {
            return await InvoiceContext.Invoices.Where(x => x.InvoiceDate == date).ToArrayAsync();
        }
    }
}
