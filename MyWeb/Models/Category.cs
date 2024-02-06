using MyWeb.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MyWeb.Models
{
    public class Category: IEntityBase
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category Name is required")]
        public string? CategoryName { get; set; }
        [Display(Name ="Image")]
        [Required (ErrorMessage = "Image Url is required")]
        public string? CategoryImageUrl { get; set; }

        //relationships
        public List<Products>? Products { get; set;}
    }
}
