namespace PizzaShop.Data.Services
{
    public class PizzaService
    {
        private List<Pizza> pizzaList = new()
        {
            new Pizza { Id = 1, Name = "Margherita", Price = 4.99m, Description = "Tomatensaus, mozzarella en basilicum.", ImageUrl = "images/margherita.jpg" },
            new Pizza { Id = 2, Name = "Pepperoni", Price = 10.99m, Description = "Tomatensaus, mozzarella en pepperoni.", ImageUrl = "images/pepperoni.jpg" },
            new Pizza { Id = 3, Name = "BBQ Chicken", Price = 8.99m, Description = "BBQ Saus, kip, ui en mozzarella.", ImageUrl = "images/bbq_chicken.jpg" }
        };

        private List<Pizza> orderList = new();

        // ✅ Ophalen van beschikbare pizza’s
        public Task<List<Pizza>> GetPizzasAsync() => Task.FromResult(pizzaList.ToList());

        // ✅ Ophalen van bestelde pizza’s
        public List<Pizza> GetOrderedPizzas() => orderList.ToList();

        // ✅ Pizza toevoegen aan de bestelling
        public void AddToOrder(Pizza pizza)
        {
            if (pizza != null)
                orderList.Add(new Pizza
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Price = pizza.Price,
                    Description = pizza.Description,
                    ImageUrl = pizza.ImageUrl
                });
        }

        // ✅ Pizza verwijderen uit de bestelling
        public void RemoveFromOrder(Pizza pizza)
        {
            var item = orderList.FirstOrDefault(p => p.Id == pizza.Id);
            if (item != null)
            {
                orderList.Remove(item);
            }
        }

        // ✅ Totale prijs van de bestelling berekenen
        public decimal GetTotalPrice() => orderList.Sum(p => p.Price);
    }
}
