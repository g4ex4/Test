using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Dish
    {
        public string Name { get; set; }
        public List<Product> Ingredients { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }
        public Dish(string name, List<Product> ingredients, int cost,
            int weight)
        {
            Name = name;
            Ingredients = ingredients;
            Cost = cost;
            Weight = weight;
        }
        
        
        public override string ToString()
        {
            return $"{Name} \t {Cost} \t _____________ \t {Weight}";
        }
    }
}
