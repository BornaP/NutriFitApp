using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NutriFitApp.Model;

namespace NutriFitApp.Test
{
    [TestClass]
    public class FoodRepositoryTest
    {
        [TestMethod]
        public void TestAddOneMeal()
        {
            Food meal = new Food("Lazanje", new Nutrients(700, 8, 50, 50));
            int counter = FoodRepository.getInstance().Count();

            FoodRepository.getInstance().AddNewMeal(meal);

            Assert.AreEqual(counter + 1, FoodRepository.getInstance().Count());
            Assert.AreSame(meal, FoodRepository.getInstance().GetMealByName(meal.Name));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidFoodException))]
        public void TestAddFoodWithNegativeCalories()
        {
            Food meal1 = new Food("Lazanje", new Nutrients(700, 8, 50, 50));
            Food meal2 = new Food("Pizza", new Nutrients(1000, 20, 100, 50));
            Food meal3 = new Food("Celer", new Nutrients(-1, -2, 0, 0));

            FoodRepository.getInstance().AddNewMeal(meal1);
            FoodRepository.getInstance().AddNewMeal(meal2);
            FoodRepository.getInstance().AddNewMeal(meal3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidFoodException))]
        public void TestWrongNutritionValue()
        {
            Food meal1 = new Food("Krive lazanje", new Nutrients(70, 8, 50, 50));

            FoodRepository.getInstance().AddNewMeal(meal1);
        }
    }
}
