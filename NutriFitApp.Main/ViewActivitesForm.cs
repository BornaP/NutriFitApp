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
    public partial class ViewActivitesForm : Form, IViewActivites, Observer
    {
        public ViewActivitesForm()
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

        private void ViewActivitesForm_Load(object sender, EventArgs e)
        {
            Update();
        }


    }
}
