using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class MassGainDiet : DietRegime
    {
        private Nutrients remainingNutr;
        public MassGainDiet(): base(){}

        public override Nutrients CalculateRecommendedDiet(PersonInfo inPersonInfo)
        {
            int calories = BasalCalorieValue(inPersonInfo.Age, inPersonInfo.Gender, inPersonInfo.Weight) + 1000;
            int proteins = BasalProteinsValue(inPersonInfo.Gender, inPersonInfo.Weight) + 100;
            int carbs = BasalCarbsValue() + 100;
            int fats = BasalFatsValue(calories) + 20;

            remainingNutr = new Nutrients(calories, proteins, carbs, fats);

            IterateThroughMeals(remainingNutr);
            IterateThroughActivities(remainingNutr);

            return remainingNutr;
        }
    }
}
