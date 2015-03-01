using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public abstract class DietRegime
    {
        abstract public Nutrients CalculateRecommendedDiet(PersonInfo inPersonInfo);
        protected void IterateThroughMeals(Nutrients remainingNutr)
        {
            List<Food> allMeals = FoodRepository.getInstance().GetAllMeals();

            foreach (Food meal in allMeals)
            {
                remainingNutr.Calories -= meal.NutritionalValue.Calories;
                remainingNutr.Proteins -= meal.NutritionalValue.Proteins;
                remainingNutr.Carbs -= meal.NutritionalValue.Carbs;
                remainingNutr.Fats -= meal.NutritionalValue.Fats;
            }
        }
        protected void IterateThroughActivities(Nutrients remainingNutr)
        {
            List<Activity> allActivities = ActivityRepository.getInstance().GetAllActivites();

            foreach (Activity activity in allActivities)
            {
                Nutrients toCompensate = activity.NutrientsToCompensate();

                remainingNutr.Calories += toCompensate.Calories;
                remainingNutr.Proteins += toCompensate.Proteins;
                remainingNutr.Carbs += toCompensate.Carbs;
                remainingNutr.Fats += toCompensate.Fats;
            }

        }

        protected int BasalCalorieValue(int age, Gender gender, decimal weight)
        {
            int basalCalorieValue;

            if (gender == Gender.Male && age < 50)
            {
                basalCalorieValue = 2500;
            }
            else
            {
                basalCalorieValue = 2000;
            }

            return (basalCalorieValue / 100) * Convert.ToInt32(weight);
        }

        protected int BasalProteinsValue(Gender gender, decimal weight)
        {
            if (gender == Gender.Female)
            {
                return Convert.ToInt32(Math.Round(Convert.ToDouble(weight) * 0.75));
            }
            else { return Convert.ToInt32(weight) * 1; }
        }

        protected int BasalCarbsValue()
        {
            return 150;
        }

        protected int BasalFatsValue(int calories)
        {
            return Convert.ToInt32(calories / 40);
        }
    }
}
