namespace MyWeb.Models
{
    public class Products_Capacity
    {
        public int Capacity_Id { get; set; }
        public Capacity Capacity { get; set; }

        public int Sku_Code { get; set; }
        public Products Products { get; set; }
    }
}
