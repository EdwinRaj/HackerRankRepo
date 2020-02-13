using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions
{
    public class SmallestMissingPositiveInteger
    {
        public static int Solution(int[] A)
        {
            int smallest = 1;
            foreach(int number in A.OrderBy(x => x))
            {
                if (number > 0 && number == smallest)
                    smallest++;
                else if(number > smallest)
                {
                    break;
                }
            }

            return smallest;
        }
    }
}
