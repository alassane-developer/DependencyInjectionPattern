using DIExample.Models;

namespace DIExample.Interfaces;

public interface IInvoiceService
{
    void ProcessInvoice(Invoice invoice);
}
