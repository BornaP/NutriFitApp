using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class Food
    {
        private string name;
        private Nutrients nutritionalValue;

        public Food(string name, Nutrients nutritionalValue)
        {
            this.name = name;
            this.nutritionalValue = nutritionalValue;
        }
        //provjeri jos koje se koriste/ne koriste
        #region get/set Methods
        public string Name 
        {
            get
            {
               return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Nutrients NutritionalValue
        {
            get
            {
                return this.nutritionalValue;
            }
            set
            {
                this.nutritionalValue = value;
            }
        }
        #endregion

    }
}
