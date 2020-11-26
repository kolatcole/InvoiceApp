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
            return View(await _service.GetAllInvoicesByCreationDate(filterDate));
        }

        

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



    }
}
