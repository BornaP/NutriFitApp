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
using NutriFitApp.Controllers;

namespace NutriFitApp.Main
{
    public partial class MainForm : Form, IMainFormView
    {
        private PersonController personController = new PersonController();
        private FoodController foodController = new FoodController();
        private ActivityController activityController = new ActivityController();
        public MainForm()
        {
            InitializeComponent();
        }

        #region Person related info properties
        public int Age
        {
            get { return Convert.ToInt32(numericUpDownAge.Value); }
        }

        public string Gender
        {
            get
            {
                if (radioButtonFemale.Checked) { return radioButtonFemale.Text; }
                else return radioButtonMale.Text;
            }
        }

        public decimal Weight
        {
            get { return numericUpDownWeight.Value; }
        }

        public string DietRegime
        {
            get { return comboBoxDietRegime.GetItemText(comboBoxDietRegime.SelectedItem); }
        }
        #endregion

        private void buttonUpdateInfo_Click(object sender, EventArgs e)
        {
            personController.UpdatePersonInfo(this);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            AddMealForm outForm = new AddMealForm();

            foodController.AddNewMeal(outForm);
        }

        private void btnViewMeals_Click(object sender, EventArgs e)
        {
            ViewConsumedMealsForm outForm = new ViewConsumedMealsForm();

            foodController.ViewConsumedMeals(outForm);
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityForm outForm = new AddActivityForm();

            activityController.AddNewActivity(outForm);
        }

        private void btnViewActivites_Click(object sender, EventArgs e)
        {
            ViewActivitesForm outForm = new ViewActivitesForm();

            activityController.ViewActivities(outForm);
        }
        private void buttonDietSummary_Click(object sender, EventArgs e)
        {
            personController.UpdatePersonInfo(this);
            DietSummaryView outForm = new DietSummaryView();

            foodController.attachObserver(outForm);
            activityController.attachObserver(outForm);

            personController.CalculateDiet(outForm);
        }

        private void buttonNewDay_Click(object sender, EventArgs e)
        {
            foodController.ClearAllMeals();
            activityController.ClearAllActivities();
        }
    }
}
