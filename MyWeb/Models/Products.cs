using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWeb.Models
{
    public class Products
    {
        [Key]
        [Display(Name = "Product_Id")]
        public int Product_Id { get; set; }     

        [Display(Name = "Sku_Code")]
        public int Sku_Code { get; set; }
        [Display(Name = "Product Name ")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        public string Price { get; set; }
        [Display(Name = "Product Image")]
        public string ImageUrl { get; set; }

        //relationship
        public List<Products_Capacity> Products_Capacities { get; set; }
        //public List<OrderItem> OrderItems { get; set; }


        //category
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Category Category { get; set; }
    }
}
