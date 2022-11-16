using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class DishData : ISerializable
    {
        public List<Dish> Dishes { get; private set; } = new List<Dish>();

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        public string FileName { get; set; } = nameof(DishData);
    }
}
