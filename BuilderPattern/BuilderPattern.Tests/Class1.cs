using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Tests
{
    public class InvoiceBuilder
    {
        private Invoice _invoice;

        public InvoiceBuilder() {
            _invoice = new Invoice();
        }

        public InvoiceBuilder WithInvoiceNumber(int invoiceNumber) {
            _invoice.InvoiceNumber = invoiceNumber;
            return this;
        }

        public InvoiceBuilder WithClientName(string clientName) {
            _invoice.ClientName = clientName;
            return this;
        }



        public Invoice Build() {
            return _invoice;
        }
    }

    public class ProductBuilder {
        private Product _product;

        public ProductBuilder() {
            
        }

        public Product Build() {
            return _product;
        }
    }

}
