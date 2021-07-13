using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köket.Core.Entities
{
    public class Household
    {
        public string Id { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }

    }
}
