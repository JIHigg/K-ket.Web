using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köket.Core.Entities
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }

        //Nav
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
