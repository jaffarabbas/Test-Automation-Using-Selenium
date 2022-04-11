using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Class_5
{
    public class DistanceClass
    {
        public double Ditance(double speed,double time)
        {
            return speed * time;
        }

        public double CordinateDistance(double[] x,double[] y) 
        {
            return Math.Sqrt((Math.Pow(x[0] - x[1],2)) + (Math.Pow(y[0] - y[1],2)));
        }
    }
}
