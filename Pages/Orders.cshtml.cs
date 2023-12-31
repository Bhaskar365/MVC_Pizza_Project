using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProject.Data;
using PizzaProject.Models;

namespace PizzaProject.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> pizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context) 
        {
            _context = context;   
        }

        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
