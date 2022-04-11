using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDClass4
{
    public class Class1
    {
        public string CaclulateBMI(double weight, double height, string gender)
        {
            double bmi = (weight / (height * height));

            if (bmi < 19 && gender == "f")
            {
                return "UnderWeight";

            }
            else if ((bmi >= 19 && bmi <= 24) && gender == "f")
            {
                return "Normal";
            }
            else if (bmi > 24 && gender == "f")
            {
                return "Over";
            }
            else if (bmi < 20 && gender == "m")
            {
                return "UnderWeight";

            }
            else if ((bmi >= 20 && bmi <= 25) && gender == "m")
            {
                return "Normal";
            }
            else if (bmi > 25 && gender == "m")
            {
                return "Over";
            }
            else
            {
                return "";
            }
        }

        public string CaclulateBMIPound(double weight, double height, string gender)
        {
            double bmi = ((weight/2.2) / (height * height));

            if (bmi < 19 && gender == "f")
            {
                return "UnderWeight";

            }
            else if ((bmi >= 19 && bmi <= 24) && gender == "f")
            {
                return "Normal";
            }
            else if (bmi > 24 && gender == "f")
            {
                return "Over";
            }
            else if (bmi < 20 && gender == "m")
            {
                return "UnderWeight";

            }
            else if ((bmi >= 20 && bmi <= 25) && gender == "m")
            {
                return "Normal";
            }
            else if (bmi > 25 && gender == "m")
            {
                return "Over";
            }
            else
            {
                return "";
            }
        }
    }
}
