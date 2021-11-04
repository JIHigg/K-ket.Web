using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Köket.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Köket.Data.Data
{
    public class SeedData
    {
        private readonly ApplicationDbContext db;

        private readonly UserManager<ApplicationUser> userManager;
        public int NumberOfUsers { get; private set; }
        public int NumberOfHouseholds { get; set; }
        public int NumberOfMenus { get; set; }
        public int NumberOfRecipes { get; set; }
        public int NumberOfIngredients { get; set; }
        public int NumberOfFoods { get; set; }



        //Constructor
        public SeedData(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;

            // Set Random to a fixed number to generate the same data each time Randomizer.Seed =
            // new Random(12345);
            Randomizer.Seed = new Random();
            Faker fake = new Faker();

            NumberOfHouseholds = 5;
            NumberOfUsers = 2 * NumberOfHouseholds;
            NumberOfMenus = 4 * NumberOfHouseholds;
            NumberOfRecipes = 20;
            NumberOfFoods = NumberOfRecipes * fake.Random.Number(10);
            NumberOfIngredients = NumberOfRecipes * NumberOfFoods;
            
        }

        public void Seed(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {

            //db.SaveChanges();
        }
    }
}
