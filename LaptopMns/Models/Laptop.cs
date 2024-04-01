namespace LaptopManagementSystem.Models
{
    public class Laptop
    {
        public int LaptopId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int ProcessorId { get; set; }
        public int RAMId { get; set; }
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}