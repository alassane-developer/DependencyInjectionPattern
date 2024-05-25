using DIExample.Interfaces;
using DIExample.Models;
using DIExample.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DIExample;

internal static class Program
{
    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddTransient<IInvoiceService, InvoiceService>();
                services.AddTransient<IEmailService, EmailService>();
            })
            .Build();

        var invoice = new Invoice(1, 100.5);
        var invoiceService = host.Services.GetRequiredService<IInvoiceService>();
        invoiceService.ProcessInvoice(invoice);
    }
}
