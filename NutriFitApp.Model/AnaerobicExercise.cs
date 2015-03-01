using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class AnaerobicExercise : Activity
    {
        public AnaerobicExercise(string activityName, int caloriesLost)
            : base(activityName, caloriesLost)
        {

        }

        public override Nutrients NutrientsToCompensate()
        {
            int proteinsToComp = this.caloriesLost / 10;
            int carbsToComp = this.caloriesLost / 10;
            int fatsToComp = this.caloriesLost / 50;

            return new Nutrients(this.caloriesLost, proteinsToComp, carbsToComp, fatsToComp);
        }

    }
}
