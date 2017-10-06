using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern {

    public class Invoice {
        public int InvoiceNumber { get; set; }
        public string ClientName { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public decimal InvoiceTotal { get => Products.Sum(x => x.Price); }
    }

    public abstract class Product {
        public abstract decimal Price { get; }
    }

    public class SimpleProduct : Product {
        private decimal _price;
        public decimal SetPrice { set => _price = value; }

        public override decimal Price { get => _price; }        
    }

    public class ConfigurableProduct : Product {
        public List<ConfigurableProductOption> Options { get; set; } = new List<ConfigurableProductOption>();
        public override decimal Price { get => Options.Sum(x => x.Value); }
    }

    public class ConfigurableProductOption {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
