using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Restauran
    {
        public string Name { get;set;}
        public string ChiefName { get; set; }
        public List<Dish> Dishes { get; set; }
        public decimal ServicePercent { get; set; }
        public Restauran (string name, string chiefName, List<Dish> dishes,
            decimal servicePercent = 0.2M)
        {
            Name = name;
            ChiefName = chiefName;
            Dishes = dishes;
        }
        public Restauran ()
        {
            Name = "";
            ChiefName = "";
            Dishes = new List<Dish> ();
            ServicePercent = 0.2M;
        }
        public void CheckRestauran ()
        {
            Console.WriteLine($"Meal \t Cost \t Ingredients \t Weight");
            foreach (var  dish in Dishes)
            {
                Console.WriteLine(dish);
            }
            Console.WriteLine($"\t\t\t ServicePercent:{ServicePercent} %");
        }
    }
}
