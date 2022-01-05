using FactoryPattern.Enumurations;
using FactoryPattern.Services;
using FactoryPattern.Services.IServices;

namespace FactoryPattern.Factories
{
    public class InvoiceFactory
    {
        public static IInvoiceService CreateInvoice(InvoiceType invoiceType)
        {
            if (invoiceType== InvoiceType.InvoiceWithHeader)
            {
                return new InvoiceWithHeaderService();
            }
            else if (invoiceType == InvoiceType.InvoiceWithoutHeader)
            {
                return new InvoiceWithoutHeaderService();
            }
            else
            {
                //Should create Null Object pattern
                return null;
            }
        }
    }
}
