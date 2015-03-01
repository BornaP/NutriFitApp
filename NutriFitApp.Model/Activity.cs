using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public abstract class  Activity
    {
        protected string name;
        protected int caloriesLost;

        public string Name
        {
            get { return name; }
        }

        public int CaloriesLost
        {
            get { return caloriesLost; }
        }

        public Activity(string activityName, int caloriesLost)
        {
            this.name = activityName;
            this.caloriesLost = caloriesLost;
        }

        abstract public Nutrients NutrientsToCompensate();

    }
}
