using System;
using FluentAssertions;
using NUnit.Framework;

namespace BuilderPattern.Tests
{
    [TestFixture]
    public class InvoiceTest
    {
        [Test]
        public void CalculatePriceOnNewInvoice()
        {
            var invoice = new InvoiceBuilder()
                .Build();

            invoice.InvoiceTotal.Should().Be(0);
        }

        [Test]
        public void CalculateInvoiceTotalWithOnlySimpleProducts()
        {
            var invoice = new InvoiceBuilder()
                .WithProduct(pb => pb.WithPrice(10))
                .Build();

            invoice.InvoiceTotal.Should().Be(10);
        }

        [Test]
        public void CalculateInvoiceWhenOverdue()
        {
            var invoice = new InvoiceBuilder()
                .WithProduct(pb => pb.WithPrice(10))
                .WithDueDate(DateTime.Now.AddDays(-35))
                .Build();

            invoice.InvoiceTotal.Should().Be(15);
        }
    }
}
