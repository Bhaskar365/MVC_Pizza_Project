using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProject.Models;

namespace PizzaProject.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() 
        {
            new PizzasModel() 
             { ImageTitle = "Margerita" , PizzaName="Margerita" , BasePrice=2, TomatoSauce = true, Cheese=true, Mushroom=true, Beef=false, Ham=true, FinalPrice=4 },
            new PizzasModel()
             { ImageTitle = "Bolognese" , PizzaName="Bolognese" , BasePrice=2, TomatoSauce = true, Cheese=true, Mushroom=false, Beef=false, Ham=true, FinalPrice=5 },
            new PizzasModel()
             { ImageTitle = "Carbonara" , PizzaName="Carbonara" , BasePrice=2, TomatoSauce = false, Cheese=false, Mushroom=true, Beef=true, Ham=true, FinalPrice=5 },
            new PizzasModel()
             { ImageTitle = "Hawaiian" , PizzaName="Hawaiian" , BasePrice=2, TomatoSauce = true, Cheese=true,Mushroom=true, Beef=false, Ham=true, FinalPrice=6 },
            new PizzasModel()
             { ImageTitle = "MeatFeast" , PizzaName="MeatFeast" , BasePrice=2, TomatoSauce = false, Cheese=false,Mushroom=false, Beef=true, Ham=true, FinalPrice=7 },
            new PizzasModel()
             { ImageTitle = "Mushroom" , PizzaName="Mushroom" , BasePrice=2, TomatoSauce = true, Cheese=false,Mushroom=true, Beef=false, Ham=false, FinalPrice=6 },
            new PizzasModel()
             { ImageTitle = "Pepperoni" , PizzaName="Pepperoni" , BasePrice=2, TomatoSauce = true, Cheese=true,Mushroom=true, Beef=false, Ham=false, FinalPrice=5 },
            new PizzasModel()
             { ImageTitle = "Seafood" , PizzaName="Seafood" , BasePrice=2, TomatoSauce = false, Cheese=false,Mushroom=false, Beef=false, Ham=true, FinalPrice=8 },
            new PizzasModel()
             { ImageTitle = "Vegetarian" , PizzaName="Vegetarian" , BasePrice=2, TomatoSauce = true, Cheese=false, Mushroom=true, Beef=false, Ham=false ,FinalPrice=7 },

        };
        public void OnGet()
        {
        }


    }
}
