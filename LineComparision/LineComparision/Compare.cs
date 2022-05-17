using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Compare
    {
        public void CompareLength(double len1, double len2)
        {
            if (len1 == len2)
            {
                Console.WriteLine("Both line lengths are equal");
            }
            else if (len1 < len2)
            {
                Console.WriteLine("Line1 is lessthan Line2");
            }
            else
                Console.WriteLine("Line2 is lessthan Line1");
        }
    }
}
