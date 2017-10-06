using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BuilderPattern.Tests {

    [TestFixture]
    public class InvoiceTest {
        private InvoiceBuilder _invoiceBuilder;

        [SetUp]
        public void Setup() {
            _invoiceBuilder = new InvoiceBuilder();
            _invoiceBuilder.WithClientName("Mon client")
                .WithInvoiceNumber(123);
        }

        [Test]
        public void CalculateInvoiceTotalWithNoProducts() {

        }

        [Test]
        public void CalculateInvoiceTotalWithOnlySimpleProducts() {

        }

        [Test]
        public void CalculateInvoiceTotalWithOnlyConfigurableProducts() {

        }

        [Test]
        public void CalculateInvoiceTotalWithSimpleAndConfigurableProducts() {

        }
    }
}
