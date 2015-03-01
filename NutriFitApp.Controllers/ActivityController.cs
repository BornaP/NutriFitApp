using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NutriFitApp.Common;
using NutriFitApp.Model;

namespace NutriFitApp.Controllers
{
    public class ActivityController : Subject
    {

        public void AddNewActivity(IAddNewActivity inForm)
        {
            if (inForm.Show())
            {
                string name = inForm.ActivityName;
                int caloriesLost = inForm.CaloriesLost;
                Activity newActivity;

                if (inForm.ActivityType == "Aerobic Exercise")
                {
                    newActivity = new AerobicExercise(name, caloriesLost);
                }
                else if (inForm.ActivityType == "Anaerobic Exercise")
                {
                    newActivity = new AnaerobicExercise(name, caloriesLost);
                }
                else
                {
                    newActivity = new FlexibilityExercise(name, caloriesLost);
                }

                ActivityRepository.getInstance().AddNewActivity(newActivity);

                notifyObservers();
            }
        }

        public void ViewActivities(IViewActivites inForm)
        {
            attachObserver(inForm);
            inForm.ShowForm();
        }

        public void ClearAllActivities()
        {
            ActivityRepository.getInstance().StartANewDay();
            notifyObservers();
        }
    }
}
