using Test;
Restauran rest = new Restauran("KFC", "Ashir", new List<Dish> 
    {
    
    }
);
rest.Dishes = new List<Dish>();
rest.Dishes.Add(new Dish("Oliv'e", new List<Product> (), 100, 200));
rest.CheckRestauran();