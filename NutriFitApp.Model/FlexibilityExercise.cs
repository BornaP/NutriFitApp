using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class FlexibilityExercise : Activity
    {
        public FlexibilityExercise(string activityName, int caloriesLost)
            : base(activityName, caloriesLost)
        {

        }

        public override Nutrients NutrientsToCompensate()
        {
            int proteinsToComp = this.caloriesLost / 5;
            int carbsToComp = this.caloriesLost / 20;

            return new Nutrients(this.caloriesLost, proteinsToComp, carbsToComp, 0);
        }
    }
}
