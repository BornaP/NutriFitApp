using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class Nutrients
    {
        private int proteins;
        private int carbs;
        private int fats;
        private int calories;

        public Nutrients(int calories, int proteins, int carbs, int fats)
        {
            this.calories = calories;
            this.proteins = proteins;
            this.carbs = carbs;
            this.fats = fats;
        }

        public int Calories
        {
            get { return calories; }
            set { this.calories = value; }
        }
        public int Proteins
        {
            get { return proteins; }
            set { this.proteins = value; }
        }

        public int Carbs
        {
            get { return carbs; }
            set { this.carbs = value; }
        }

        public int Fats
        {
            get { return fats; }
            set { this.fats = value; }
        }
    }
}
