using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Line
    {
        public double getLength(double x1,double y1,double x2,double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
	public Boolean lengthEquaity(double len1,double len2)
        {
            return len1 == len2;
        }
    }
}
