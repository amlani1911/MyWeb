using MyWeb.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public class Capacity
    {
        [Key]
        [Display(Name = "Capacity Id")]
        public int Capacity_Id { get; set; }

        [Display(Name = "Capacity")]
        [Required(ErrorMessage = "Capacity is required")]
        public string Cap { get; set; }

        //relationship
        public List<Products_Capacity> Products_Capacities { get; set; }
    }
}
