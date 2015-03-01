using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NutriFitApp.Common;

namespace NutriFitApp.Main
{
    public partial class AddMealForm : Form, IAddNewMeal
    {
        public AddMealForm()
        {
            InitializeComponent();
        }

        public bool Show()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FoodName
        {
            get { return textBoxFoodName.Text; }
        }

        public int Calories
        {
            get { return Convert.ToInt32(numericUpDownCalories.Value); }
        }

        public int Proteins
        {
            get { return Convert.ToInt32(numericUpDownProteins.Value); }
        }

        public int Carbs
        {
            get { return Convert.ToInt32(numericUpDownCarbs.Value); }
        }

        public int Fats
        {
            get { return Convert.ToInt32(numericUpDownFats.Value); }
        }
    }
}
