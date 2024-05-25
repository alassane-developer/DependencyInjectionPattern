using DIExample.Interfaces;
using DIExample.Models;
using DIExample.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DIExample;

internal static class Program
{
    static void Main()
    {
        // register the services
        var services = new ServiceCollection();
        services.AddTransient<IInvoiceService, InvoiceService>();
        services.AddTransient<IEmailService, EmailService>();

        // build the service provider
        var sp = services.BuildServiceProvider();

        var invoice = new Invoice(1, 100.5);
        var invoiceService = sp.GetRequiredService<IInvoiceService>();
        invoiceService.SendInvoice(invoice);
    }
}
