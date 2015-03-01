using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    public class ActivityRepository
    {
        private static ActivityRepository _instance = null;

        List<Activity> activitesRepo = new List<Activity>();

        public static ActivityRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new ActivityRepository();
                _instance.activitesRepo.Add(new AnaerobicExercise("Dizanje gewictha", 500));
            }

            return _instance;
        }
        //private bool Exists(string activityName)
        //{
        //    if (activitesRepo.Exists(a => a.Name == activityName))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public void AddNewActivity(Activity inActivity)
        {
            if (inActivity.Name == "")
            {
                throw new InvalidActivityException();
            }
            else
            {
                activitesRepo.Add(inActivity);
            }
        }

        public Activity GetActivityByName(string activityName)
        {
            try
            {
                Activity fetchedActivity = activitesRepo.Find(a => a.Name == activityName);

                return fetchedActivity;
            }
            catch
            {
                throw new NullReferenceException();
            }
        }

        public List<Activity> GetAllActivites()
        {
            return this.activitesRepo;
        }

        public void StartANewDay()
        {
            this.activitesRepo.Clear();
        }

        public int Count()
        {
            return this.activitesRepo.Count;
        }
    }
}
