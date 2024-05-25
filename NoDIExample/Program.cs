using NoDIExample.Models;
using NoDIExample.Services;

namespace NoDIExample;

public static class Program
{
    static void Main()
    {
        var invoice = new Invoice(1, 100.5);
        var invoiceService = new InvoiceService();
        invoiceService.SendInvoice(invoice);
    }
}
