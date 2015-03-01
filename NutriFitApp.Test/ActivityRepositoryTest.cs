using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NutriFitApp.Model;

namespace NutriFitApp.Test
{
    [TestClass]
    public class ActivityRepositoryTest
    {
        [TestMethod]
        public void TestAddSameActivites()
        {
            Activity activity1 = new AerobicExercise("Trcanje po nasipu", 500);
            Activity activity2 = new AerobicExercise("Trcanje po nasipu", 300);
            int counter = ActivityRepository.getInstance().Count();
            //dozvoljeno je imati iste aktivnosti vise puta dnevno zasto ne!

            ActivityRepository.getInstance().AddNewActivity(activity1);
            ActivityRepository.getInstance().AddNewActivity(activity2);

            Assert.AreEqual(counter + 2, ActivityRepository.getInstance().Count());
            Assert.AreSame(activity1, ActivityRepository.getInstance().GetActivityByName(activity1.Name));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidActivityException))]
        public void TestNoNameActivity()
        {
            Activity activity3 = new AnaerobicExercise("", 1000);

            ActivityRepository.getInstance().AddNewActivity(activity3);
        }
    }
}
