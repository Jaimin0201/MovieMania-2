using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMania.Models
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}