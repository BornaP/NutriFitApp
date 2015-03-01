using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NutriFitApp.Common;
using NutriFitApp.Model;

namespace NutriFitApp.Controllers
{
    public class FoodController : Subject
    {

        public void AddNewMeal(IAddNewMeal inForm)
        {
            if ( inForm.Show() )
            {
                string foodName = inForm.FoodName;
                Nutrients nutrients = new Nutrients(inForm.Calories ,inForm.Proteins, inForm.Carbs, inForm.Fats);

                Food newMeal = new Food(foodName, nutrients);

                FoodRepository.getInstance().AddNewMeal(newMeal);

                notifyObservers();
            }
        }

        public void ViewConsumedMeals(IViewConsumedMeals inForm)
        {
            attachObserver(inForm);
            inForm.ShowForm();
        }

        public void ClearAllMeals()
        {
            FoodRepository.getInstance().StartANewDay();
            notifyObservers();
        }
    }
}
