using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern {

    public class Invoice {
        public int InvoiceNumber { get; set; }
        public string ClientName { get; set; }
        public DateTime DueDate { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public decimal InvoiceTotal { get => Products.Sum(x => x.Price) * ((DateTime.Now - DueDate).TotalDays > 30 ? 1.5m : 1); }
        
    }

    public class Product {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Client
    {
        public string Name { get; set; }
        public bool IsPreferredCustomer { get; set; }
    }
}
