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
using NutriFitApp.Model;

namespace NutriFitApp.Main
{
    public partial class ViewConsumedMealsForm : Form, IViewConsumedMeals, Observer
    {
        public ViewConsumedMealsForm()
        {
            InitializeComponent();
        }

        public bool ShowForm()
        {
            this.Show();

            return true;
        }
        public void Update()
        {
            listViewMeals.Items.Clear();

            List<Food> consumedMeals = FoodRepository.getInstance().GetAllMeals();

            foreach (Food meal in consumedMeals)
            {
                ListViewItem viewItem = new ListViewItem(meal.Name);
                viewItem.SubItems.Add(meal.NutritionalValue.Calories.ToString());
                viewItem.SubItems.Add(meal.NutritionalValue.Proteins.ToString());
                viewItem.SubItems.Add(meal.NutritionalValue.Carbs.ToString());
                viewItem.SubItems.Add(meal.NutritionalValue.Fats.ToString());

                listViewMeals.Items.Add(viewItem);
            }
        }

        private void ViewConsumedMealsForm_Load(object sender, EventArgs e)
        {
            Update();
        }
    }
}
