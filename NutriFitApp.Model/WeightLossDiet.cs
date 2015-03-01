using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class WeightLossDiet : DietRegime
    {
        private Nutrients remainingNutr;
        public WeightLossDiet():base() { }
        public override Nutrients CalculateRecommendedDiet(PersonInfo inPersonInfo)
        {
            int calories = BasalCalorieValue(inPersonInfo.Age, inPersonInfo.Gender, inPersonInfo.Weight) - 500;
            int proteins = BasalProteinsValue(inPersonInfo.Gender, inPersonInfo.Weight) + 30;
            int carbs = BasalCarbsValue() - 100;
            int fats = BasalFatsValue(calories) - 30;

            remainingNutr = new Nutrients(calories, proteins, carbs, fats);

            IterateThroughMeals(remainingNutr);
            IterateThroughActivities(remainingNutr);

            return remainingNutr;
        }
    }
}
