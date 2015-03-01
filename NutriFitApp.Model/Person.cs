using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class Person
    {
        private static Person _instance = null;

        private PersonInfo personalInfo;
        private DietRegime dietRegime;

        private Person(int age, Gender gender, decimal weight, DietRegime diet)
        {
            this.personalInfo = new PersonInfo(age, gender, weight);
            this.dietRegime = diet;
        }

        public static void UpdateProfile(int age, Gender gender, decimal weight, DietRegime diet)
        {
            if (diet == null)
            {
                throw new DietRegimeNotSetException();
            }
            if (_instance == null)
            {
                _instance = new Person(age, gender, weight, diet);
            }
            else
            {
                if (age <= 0 || weight <= 0)
                {
                    throw new InvalidPyhsioInfoException();
                }

                _instance.personalInfo.Age = age;
                _instance.personalInfo.Gender = gender;
                _instance.personalInfo.Weight = weight;
                _instance.dietRegime = diet;
            }
        }

        public static Person getInstance() 
        {
            if (_instance == null)
            {
                throw new PersonNotDefinedException();
            }
            return _instance;
        }
        //public void StartANewDay()
        //{
        //    try
        //    {
        //        this.PhysicalActivites.Clear();
        //        this.Meals.Clear();
        //    }
        //    catch
        //    {
        //        throw new NutriFitBaseException();
        //    }

        //}

        public Nutrients RemainingInputOfNutrients()
        {
            if (dietRegime == null)
            {
                throw new DietRegimeNotSetException();
            }
            try
            {
                Nutrients returnValue = this.dietRegime.CalculateRecommendedDiet(this.personalInfo);

                return returnValue;
            }

            catch
            {
                throw new InvalidDietCalcultionException();
            }
            
        }

    }
}
