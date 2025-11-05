using Expenese.API.Base;

namespace Expenese.API.Model
{
    public class Transaction: BaseEntity
    {
        public string Type { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
    }
}
