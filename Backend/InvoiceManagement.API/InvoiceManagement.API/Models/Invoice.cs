namespace InvoiceManagement.API.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        
        public string CustomerName { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
