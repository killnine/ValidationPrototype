using System.ComponentModel.DataAnnotations;

namespace ValidationPrototype.Models
{
    public class BillModel
    {
        public string BillName { get; set; }

        [ValidateComplexType]
        public ContactModel BilleeContact { get; set; }

        [ValidateComplexType]
        public ContactModel BillerContact { get; set; }
    }
}
