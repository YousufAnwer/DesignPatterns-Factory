using FactoryPattern.Enumurations;
using FactoryPattern.Factories;
using FactoryPattern.Services.IServices;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoiceService invoice = InvoiceFactory.CreateInvoice(InvoiceType.InvoiceWithoutHeader);
            invoice.Print();
        }
    }
}
