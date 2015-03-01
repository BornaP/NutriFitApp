using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class PersonInfo
    {
        private int age;
        private Gender gender;
        private decimal weight;

        public PersonInfo(int age, Gender gender, decimal weight)
        {
            this.age = age;
            this.gender = gender;
            this.weight = weight;
        }

        public int Age
        {
            get { return age; }
            set { this.age = value;}
        }
        public Gender Gender
        {
            get { return gender; }
            set { this.gender = value; }
        }

        public decimal Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
    }
}
