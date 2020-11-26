using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Domain
{
    public interface IUnitofWork
    {

        void Dispose();

        int Complete();

        IInvoiceRepository Invoice { get; }

    }
}
