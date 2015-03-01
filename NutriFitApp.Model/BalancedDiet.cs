using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class BalancedDiet : DietRegime
    {
        private Nutrients remainingNutr;
        public BalancedDiet():base() { }
        public override Nutrients CalculateRecommendedDiet(PersonInfo inPersonInfo)
        {
            int calories = BasalCalorieValue(inPersonInfo.Age, inPersonInfo.Gender, inPersonInfo.Weight);
            int proteins = BasalProteinsValue(inPersonInfo.Gender, inPersonInfo.Weight);
            int carbs = BasalCarbsValue();
            int fats = BasalFatsValue(calories);

            remainingNutr = new Nutrients(calories, proteins, carbs, fats);

            IterateThroughMeals(remainingNutr);
            IterateThroughActivities(remainingNutr);

            return remainingNutr;
        }
    }
}
