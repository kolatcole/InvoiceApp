using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceApp.Core.Model
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNo { get { return "00" + new Random().Next(1, 100); } set { } }
        public string Description { get; set; }
        public string Amount { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? SettleDate { get; set; }
        public string Vat { get;  set; }
        public string ExchangeRate { get; set; }
        public string Currency { get; set; }
        public string Client { get; set; }
        public string OrderNumber { get; set; }
        public string SalesAgent { get; set; }



    }


    
    
}
