using DIExample.Models;

namespace DIExample.Interfaces;

public interface IEmailService
{
    void SendEmail(Invoice invoice);
}
