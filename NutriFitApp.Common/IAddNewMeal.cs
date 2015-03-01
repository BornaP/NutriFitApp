using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Common
{
    public interface IAddNewMeal
    {
        bool Show();
        string FoodName { get; }
        int Calories { get; }
        int Proteins { get; }
        int Carbs { get; }
        int Fats { get; }
    }
}
