using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWeb.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        public int Sku_Code { get; set; }
        [ForeignKey("Sku_Code")]
        public Products Products { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Unit { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }
        public string OrderDate { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}