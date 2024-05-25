using NoDIExample.Models;

namespace NoDIExample.Services;

public class InvoiceService
{
    private readonly EmailService _emailService;

    public InvoiceService()
    {
        _emailService = new EmailService();
    }

    public void ProcessInvoice(Invoice invoice)
    {
        Console.WriteLine($"{invoice} is processing ...");

        _emailService.SendEmail(invoice);
    }
}