using InvoiceApp.Core.Model;
using InvoiceApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Persistence
{
    public class UnitofWork : IUnitofWork
    {
        private InvoiceDBContext _context;
        public UnitofWork(InvoiceDBContext context) 
        {
            _context = context;
            Invoice = new InvoiceRepository(_context);
        }


        public IInvoiceRepository Invoice{ private set; get; }

       

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
           _context.DisposeAsync();
        }
    }
}
