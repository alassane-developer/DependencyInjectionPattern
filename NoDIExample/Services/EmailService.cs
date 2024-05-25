using NoDIExample.Models;

namespace NoDIExample.Services;

public class EmailService
{
    public void SendEmail(Invoice invoice)
    {
        Console.WriteLine($"Email sent for {invoice}");
    }
}
