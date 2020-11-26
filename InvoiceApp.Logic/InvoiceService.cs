using InvoiceApp.Core.Model;
using InvoiceApp.Domain;
using InvoiceApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace InvoiceApp.Logic
{
    public class InvoiceService : IInvoice
    {
        private readonly IUnitofWork _uow;
        public InvoiceService()
        {
            _uow = new UnitofWork(new InvoiceDBContext());
        }


        public async Task<IEnumerable<Invoice>> GetAllInvoices()
        {
            try
            {
                return await _uow.Invoice.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Invoice>> GetAllInvoicesByCreationDate(DateTime date)
        {
            try
            {
                return await _uow.Invoice.GetByDate(date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            try
            {
                return await _uow.Invoice.GetAsync(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> SaveInvoice(Invoice data)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {


                    var model = new Invoice
                    {
                        Amount = data.Amount,
                        DeliveryDate = data.DeliveryDate,
                        Description = data.Description,
                        InvoiceDate = data.InvoiceDate,
                        SettleDate = data.SettleDate,
                        Client = data.Client,
                        Currency = data.Currency,
                        ExchangeRate = data.ExchangeRate,
                        InvoiceNo = data.InvoiceNo,
                        OrderNumber = data.OrderNumber,
                        SalesAgent = data.SalesAgent,
                        Vat = data.Vat
                    };


                    await _uow.Invoice.AddAsync(data);
                    int bit =_uow.Complete();
                    ts.Complete();
                    if (bit > 0)
                    {
                        return data.Id;
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
