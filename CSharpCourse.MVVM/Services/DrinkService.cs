using CSharpCourse.MVVM.Model;
using CSharpCourse.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.MVVM.Services
{
    public class DrinkService : IDrinkService
    {
        public List<Drink> CreateDrinks()
        {
            var drinks = new List<Drink>();

            drinks.Add(new Drink() { Name = "Cola", Price = 1 });
            drinks.Add(new Drink() { Name = "Orange", Price = 1 });
            drinks.Add(new Drink() { Name = "Lemon", Price = 1 });
            drinks.Add(new Drink() { Name = "Beer", Price = 1 });

            return drinks;
        }
    }
}
