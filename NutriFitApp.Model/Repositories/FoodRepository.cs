using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class FoodRepository
    {
        private static FoodRepository _instance = null;

        List<Food> foodRepo = new List<Food>();
        
        public static FoodRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new FoodRepository();
                Nutrients nutrijentiProba = new Nutrients(1000, 50, 10, 40);
                Food proba = new Food("Janjetina",nutrijentiProba);
                Food proba2 = new Food("Posni sir", new Nutrients(200, 25, 1, 3));
                _instance.foodRepo.Add(proba);
                _instance.foodRepo.Add(proba2);
            }

            return _instance;
        }
        //private bool Exists(string mealName)
        //{
        //    if (foodRepo.Exists(f => f.Name == mealName))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public void AddNewMeal(Food inMeal)
        {
            if (inMeal.Name == "" || inMeal.NutritionalValue.Calories <= 0)
            {
                throw new InvalidFoodException();
            }
            else if (inMeal.NutritionalValue.Calories < (inMeal.NutritionalValue.Proteins + inMeal.NutritionalValue.Carbs + inMeal.NutritionalValue.Fats))
            {
                throw new InvalidFoodException();
            }
            else
            {
                foodRepo.Add(inMeal);
            }
        }

        public Food GetMealByName(string mealName)
        {
            try
            {
                Food fetchedMeal = foodRepo.Find(f => f.Name == mealName);

                return fetchedMeal;
            }
            catch
            {
                throw new NullReferenceException();
            }
        }

        public List<Food> GetAllMeals()
        {
            return this.foodRepo;
        }

        public void StartANewDay()
        {
            this.foodRepo.Clear();
        }

        public int Count()
        {
            return this.foodRepo.Count;
        }
    }
}
