using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Common
{
    public interface IAddNewActivity
    {
        bool Show();

        string ActivityName { get; }
        int CaloriesLost { get; }
        string ActivityType { get; }
    }
}
