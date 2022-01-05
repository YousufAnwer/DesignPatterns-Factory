using FactoryPattern.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Services
{
    public class InvoiceWithoutHeaderService : IInvoiceService
    {
        public void Print()
        {
            Console.WriteLine("Print Invoice With out Header");
        }
    }
}
