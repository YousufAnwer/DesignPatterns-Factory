using FactoryPattern.Services.IServices;
using System;

namespace FactoryPattern.Services
{
    public class InvoiceWithHeaderService : IInvoiceService
    {
        public void Print()
        {
            Console.WriteLine("Print Invoice With Header");
        }
    }
}
