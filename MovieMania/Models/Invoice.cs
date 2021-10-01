using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMania.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public Plan Plan { get; set; }
        public User User { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime AccessLimitDate { get; set; }


    }
}