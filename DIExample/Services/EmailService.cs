using DIExample.Interfaces;
using DIExample.Models;

namespace DIExample.Services;

public class EmailService : IEmailService
{
    public void SendEmail(Invoice invoice)
    {
        Console.WriteLine($"Email sent for {invoice}");
    }
}