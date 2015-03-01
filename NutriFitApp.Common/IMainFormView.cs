using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Common
{
    public interface IMainFormView
    {

        int Age { get; }
        string Gender { get; }
        decimal Weight { get; }
        string DietRegime { get; }

    }
}
