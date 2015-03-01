using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NutriFitApp.Model;

namespace NutriFitApp.Test
{
    [TestClass]
    public class DietRegimeTest
    {
        [TestMethod]
        public void TestStartANewDay()
        {
            Food meal1 = new Food("Lazanje", new Nutrients(700, 8, 50, 50));
            Food meal2 = new Food("Pizza", new Nutrients(1000, 20, 100, 50));
            Activity activity1 = new AnaerobicExercise("Teretana", 500);
            int cntMeals = FoodRepository.getInstance().Count();
            int cntAct = ActivityRepository.getInstance().Count();

            FoodRepository.getInstance().AddNewMeal(meal1);
            FoodRepository.getInstance().AddNewMeal(meal2);
            ActivityRepository.getInstance().AddNewActivity(activity1);

            Assert.AreEqual(cntMeals + 2, FoodRepository.getInstance().Count());
            Assert.AreEqual(cntAct + 1, ActivityRepository.getInstance().Count());

            FoodRepository.getInstance().StartANewDay();
            ActivityRepository.getInstance().StartANewDay();

            Assert.AreEqual(0, FoodRepository.getInstance().Count());
            Assert.AreEqual(0, ActivityRepository.getInstance().Count());
            
        }

        [TestMethod]
        public void TestBalancedDietRegime()
        {
            Food meal1 = new Food("Lazanje", new Nutrients(700, 8, 50, 50));
            Food meal2 = new Food("Pizza", new Nutrients(1000, 20, 100, 50));
            DietRegime diet = new BalancedDiet();
            PersonInfo prsInfo= new PersonInfo(22, Gender.Male, 90);

            FoodRepository.getInstance().AddNewMeal(meal1);
            FoodRepository.getInstance().AddNewMeal(meal2);
            Nutrients recommendation1 = diet.CalculateRecommendedDiet(prsInfo);

            Activity activity1 = new AnaerobicExercise("Teretana", 500);
            ActivityRepository.getInstance().AddNewActivity(activity1);

            Assert.AreEqual(recommendation1.Calories + 500, diet.CalculateRecommendedDiet(prsInfo).Calories);
        }

        [TestMethod]
        public void TestWeightLossDietRegime()
        {
            Food meal1 = new Food("Shake", new Nutrients(240, 50, 10, 0));
            DietRegime diet = new BalancedDiet();
            PersonInfo prsInfo = new PersonInfo(22, Gender.Male, 90);

            FoodRepository.getInstance().AddNewMeal(meal1);
            Nutrients recommendation1 = diet.CalculateRecommendedDiet(prsInfo);

            Activity activity1 = new AnaerobicExercise("Teretana", 500);
            ActivityRepository.getInstance().AddNewActivity(activity1);

            Assert.AreEqual(recommendation1.Proteins + 50, diet.CalculateRecommendedDiet(prsInfo).Proteins);
        }

        [TestMethod]
        public void TestDifferentDietRegimes()
        {
            Food meal1 = new Food("Shake", new Nutrients(240, 50, 10, 0));
            Food meal2 = new Food("Biftek", new Nutrients(500, 50, 0, 30));
            Activity activity1 = new AnaerobicExercise("Teretana", 500);
            DietRegime diet1 = new MassGainDiet();

            FoodRepository.getInstance().AddNewMeal(meal1);
            FoodRepository.getInstance().AddNewMeal(meal2);
            ActivityRepository.getInstance().AddNewActivity(activity1);
            Person.UpdateProfile(22, Gender.Male, 90, diet1);
            int caloriesDiet1 = Person.getInstance().RemainingInputOfNutrients().Calories;

            DietRegime diet2 = new BalancedDiet();
            Person.UpdateProfile(22, Gender.Male, 90, diet2);
            int caloriesDiet2 = Person.getInstance().RemainingInputOfNutrients().Calories;
            Assert.AreNotEqual(caloriesDiet1, caloriesDiet2);
        }
        [TestMethod]
        public void TestDietDifferentPersonalInfo()
        {
            Food meal1 = new Food("Shake", new Nutrients(240, 50, 10, 0));
            Food meal2 = new Food("Biftek", new Nutrients(500, 50, 0, 30));
            Activity activity1 = new AnaerobicExercise("Teretana", 500);
            DietRegime diet = new BalancedDiet();


            PersonInfo prsInfo1 = new PersonInfo(22, Gender.Male, 90);
            PersonInfo prsInfo2 = new PersonInfo(30, Gender.Female, 60);

            Assert.AreNotEqual(diet.CalculateRecommendedDiet(prsInfo1).Calories, diet.CalculateRecommendedDiet(prsInfo2).Calories);
        }

        [TestMethod]
        [ExpectedException(typeof(DietRegimeNotSetException))]
        public void TestDietRegimeUndefined()
        {
            Person.UpdateProfile(22, Gender.Male, 100, null);

            Person.getInstance().RemainingInputOfNutrients();
        }
    }
}
