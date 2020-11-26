using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvoiceApp.Core.Model;
using InvoiceApp.Domain;

namespace InvoiceApp.Presentation.Controllers
{
    public class InvoiceAppController : Controller
    {
        private readonly IInvoice _service;

        public InvoiceAppController(IInvoice service)
        {
            _service = service;
        }

        // GET: Invoices
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllInvoices());
        }

        [Route("InvoiceApp/GetByDate")]
        [Route("InvoiceApp/GetByDate/{dt?}")]
        //  [ChildActionOnly]
        public async Task<IActionResult> GetByDate(string dt)
        {
            if (dt == null)
                return View(await _service.GetAllInvoices());


            DateTime date = DateTime.Parse(dt, null, System.Globalization.DateTimeStyles.RoundtripKind);

            var filterDate = date.Date;
            //var result = await _service.GetAllInvoicesByCreationDate(filterDate);
            return View(await _service.GetAllInvoicesByCreationDate(filterDate));
        }

        // GET: Invoices/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var invoice = await _context.Invoices
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (invoice == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(invoice);
        //}

        // GET: Invoices/Create
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create(Invoice invoice)
        {
            var result = await _service.SaveInvoice(invoice);


            return RedirectToAction("Index");

        }



        // GET: Invoices/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var invoice = await _context.Invoices.FindAsync(id);
        //    if (invoice == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(invoice);
        //}

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,InvoiceNo,Description,Amount,InvoiceDate,DeliveryDate,SettleDate,Vat,ExchangeRate,Currency,Client,OrderNumber,SalesAgent")] Invoice invoice)
        //{
        //    if (id != invoice.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(invoice);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!InvoiceExists(invoice.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(invoice);
        //}

        // GET: Invoices/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var invoice = await _context.Invoices
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (invoice == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(invoice);
        //}

        //// POST: Invoices/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var invoice = await _context.Invoices.FindAsync(id);
        //    _context.Invoices.Remove(invoice);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool InvoiceExists(int id)
        //{
        //    return _context.Invoices.Any(e => e.Id == id);
        //}
    }
}
