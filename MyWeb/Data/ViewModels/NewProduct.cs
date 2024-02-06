using MyWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Data.ViewModels
{
    public class NewProduct
    {
        [Key]
        public int Product_Id { get; set; }

        [Display(Name = "Sku_Code")]
        [Required(ErrorMessage = "Sku_Code is required ")]
        public int Sku_Code { get; set; }
        [Display(Name = "ProductName")]
        [Required(ErrorMessage = "Product Name is required ")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required ")]
        public string Price { get; set; }
        [Display(Name = "Image Poster Url")]
        [Required(ErrorMessage = "Image Poster Url is required ")]
        public string ImageUrl { get; set; }
        [Display(Name = "Select a Category")]
        [Required(ErrorMessage = "Product Category is required")]
        public int CategoryId { get; set; }
        [Display(Name = "Select Capacity(s)")]
        public List<int> CapacityIds { get; set; }

    }
}
