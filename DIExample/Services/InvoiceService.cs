using DIExample.Interfaces;
using DIExample.Models;

namespace DIExample.Services;

public class InvoiceService : IInvoiceService
{
    private readonly IEmailService _emailService;

    public InvoiceService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void SendInvoice(Invoice invoice)
    {
        Console.WriteLine($"{invoice} is sending ...");

        _emailService.SendEmail(invoice);
    }
}