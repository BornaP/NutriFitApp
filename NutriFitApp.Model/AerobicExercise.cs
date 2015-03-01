using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class AerobicExercise : Activity
    {
        //private int lostCalories;
        public AerobicExercise(string activityName, int caloriesLost)
            : base(activityName, caloriesLost)
        {

        }

        public override Nutrients NutrientsToCompensate()
        {
            int proteinsToComp = this.caloriesLost / 20;
            int carbsToComp = this.caloriesLost / 10;
            int fatsToComp = this.caloriesLost / 25;

            return new Nutrients(this.caloriesLost, proteinsToComp, carbsToComp, fatsToComp);
        }
    }
}
