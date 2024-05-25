using DIExample.Models;

namespace DIExample.Interfaces;

public interface IInvoiceService
{
    void SendInvoice(Invoice invoice);
}
