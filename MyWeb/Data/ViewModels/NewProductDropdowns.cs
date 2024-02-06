using MyWeb.Models;

namespace MyWeb.Data.ViewModels
{
    public class NewProductDropdowns
    {
        public List<Capacity> Capacities { get; set; }
        public List<Category> Categories { get; set; }
        public NewProductDropdowns() 
        {
            Capacities = new List<Capacity>();
            Categories = new List<Category>();
        }
    }
}
