namespace Expenese.API.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public double amount { get; set; }
        public string Category { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
