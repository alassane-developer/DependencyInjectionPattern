using NoDIExample.Models;

namespace NoDIExample.Services;

public class InvoiceService
{
    private readonly EmailService _emailService;

    public InvoiceService()
    {
        _emailService = new EmailService();
    }

    public void SendInvoice(Invoice invoice)
    {
        Console.WriteLine($"{invoice} is sending ...");

        _emailService.SendEmail(invoice);
    }
}