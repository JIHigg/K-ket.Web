using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köket.Core.Entities
{
    /// <summary>
    /// Class for users of the application
    /// </summary>
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }

    }
}
