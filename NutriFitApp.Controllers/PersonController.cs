using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NutriFitApp.Common;
using NutriFitApp.Model;

namespace NutriFitApp.Controllers
{
    public class PersonController : Subject
    {

        public void UpdatePersonInfo(IMainFormView inForm)
        {
            int age = inForm.Age;
            Gender gender;

            if (inForm.Gender == "Male")
            {
                gender = Gender.Male;
            }
            else
            {
                gender = Gender.Female;
            }

            decimal weight = inForm.Weight;
            DietRegime diet;

            if (inForm.DietRegime == "Mass Gainer Diet")
            {
                diet = new MassGainDiet();
            }
            else if (inForm.DietRegime == "Weight Loss Diet")
            {
                diet = new WeightLossDiet();
            }
            else { diet = new BalancedDiet(); }

            Person.UpdateProfile(age, gender, weight, diet);
        }

        public void CalculateDiet(IDietSummaryView inForm) 
        {
            attachObserver(inForm);
            inForm.ShowForm();
        }

    }
}
