using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köket.Core.Entities
{
    public class Menu
    {
        public string Id { get; set; }
        public DateTime Week { get; set; }
        public string HouseholdId { get; set; }

        //Nav
        public Household Household { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

    }
}
