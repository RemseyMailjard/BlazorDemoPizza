using PizzaShaop.Components.Pages;

namespace PizzaShaop.Data.Services
{
    public class PizzaService
    {
        private List<PizzaModel> pizzaas = new()
        {
            new PizzaModel { Id = 1, Name = "Magheritta", Price = 4.99m, Description = "Tomatosaus", ImageUrl = "images/margheritta.jpg"},
            new PizzaModel { Id = 2, Name = "Pepperoni", Price = 10.99m, Description = "Tomatensaus, mozzarella en pepperoni", ImageUrl = "images/pepperoni.jpg"},
            new PizzaModel { Id = 3, Name = "BBQ Chicken", Price = 8.99m, Description = "BBQ Saus", ImageUrl = "images/bbq_chicken.jpg"},

        };

        private List<PizzaModel> orderList = new();

        public Task<List<PizzaModel>> GetPizzasAsync() => Task.FromResult(pizzaas.ToList());

        public void AddToOrder(PizzaModel pizza)
        {
            orderList.Add(pizza);
        }

        public List<PizzaModel> GetOrderedPizzas() => orderList.ToList();
        private decimal GetTotalPrice() => orderList.Sum(p => p.Price);
    }

}
