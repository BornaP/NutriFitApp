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
    public partial class DietSummaryView : Form, IDietSummaryView, Observer
    {
        public DietSummaryView()
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
            UpdateActivities();
            UpdateMeals();

            foreach (Control control in groupBoxRemainingDiet.Controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();
            }

            UpdateRemainingNutrients();

        }

        private void UpdateActivities()
        {
            listViewActivities.Items.Clear();

            List<Activity> allActivities = ActivityRepository.getInstance().GetAllActivites();

            foreach (Activity activity in allActivities)
            {
                ListViewItem viewItem = new ListViewItem(activity.Name);
                viewItem.SubItems.Add(activity.CaloriesLost.ToString());

                string activityType;
                if (activity is AnaerobicExercise)
                {
                    activityType = "Anaerobic Exercise";
                }
                else if (activity is AerobicExercise)
                {
                    activityType = "Aerobic Exercise";
                }
                else { activityType = "Flexibility Exercise"; }

                viewItem.SubItems.Add(activityType);

                listViewActivities.Items.Add(viewItem);
            }
        }

        private void UpdateMeals()
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

        private void UpdateRemainingNutrients()
        {
            Nutrients remainingNutr = Person.getInstance().RemainingInputOfNutrients();

            textBoxCal.Text = remainingNutr.Calories.ToString() + " kcal";
            textBoxProt.Text = remainingNutr.Proteins.ToString() + " grams";
            textBoxCarbs.Text = remainingNutr.Carbs.ToString() + " grams";
            textBoxFats.Text = remainingNutr.Fats.ToString() + " grams";
        }
        private void DietSummaryView_Load(object sender, EventArgs e)
        {
            Update();
        }

    }
}
