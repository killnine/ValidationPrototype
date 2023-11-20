using System.ComponentModel.DataAnnotations;

namespace ValidationPrototype.Models;

public class ContactModel
{
    public string Header { get; set; }

    [Required]
    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string PostalCode { get; set; }

    public ContactModel(string header)
    {
        Header = header;
    }
}