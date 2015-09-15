using CSharpCourse.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.MVVM.Services.Interfaces
{
    public interface IDrinkService
    {
        List<Drink> CreateDrinks();
    }
}
