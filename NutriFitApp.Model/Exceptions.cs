using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFitApp.Model
{
    [Serializable]
    public class NutriFitBaseException : Exception
    {
    }

    [Serializable]
    public class InvalidDietCalcultionException : NutriFitBaseException
    {

    }

    public class InvalidActivityException : NutriFitBaseException
    {

    }

    public class InvalidFoodException : NutriFitBaseException
    {

    }

    public class InvalidPyhsioInfoException : NutriFitBaseException
    {

    }

    public class DietRegimeNotSetException : NutriFitBaseException
    {

    }

    public class PersonNotDefinedException : NutriFitBaseException
    {

    }
}
