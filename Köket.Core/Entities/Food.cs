using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köket.Core.Entities
{
    public class Food
    {
        public string ID { get; set; }
        public string Name { get; set; }


        //Nav
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
