using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Common
{
    public class Subject
    {
        List<Observer> list = new List<Observer>();

        public void attachObserver(Observer inObs)
        {
            list.Add(inObs);
        }

        public void detachObserver(Observer inObs)
        {
            list.Remove(inObs);
        }

        public void notifyObservers()
        {
            foreach (Observer obs in list)
                obs.Update();
        }
    }
}
