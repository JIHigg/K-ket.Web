using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köket.Core.Entities
{
    public class Ingredient
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string FoodId { get; set; }
        public string RecipeId { get; set; }

        //Nav
        public Food Food { get; set; }
        public Recipe Recipe { get; set; }
    }
}
