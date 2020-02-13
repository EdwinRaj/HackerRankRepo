using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions
{
    public class JumpingOnCloud
    {
        public static int JumpingOnCloudsSolution(int[] c)
        {
            int jumps = 0;

            int onestep = 1, twoStep = 2;

            int cloudCounter = 0;

            while(cloudCounter < c.Length-1)
            {
                if(cloudCounter + twoStep < c.Length && c[cloudCounter+twoStep] == 0)
                {
                    cloudCounter = cloudCounter + twoStep;
                    jumps++;
                }
                else if(cloudCounter + onestep < c.Length && c[cloudCounter+onestep] == 0)
                {
                    cloudCounter = cloudCounter + onestep;
                    jumps++;
                }
                
            }
            return jumps;


        }
    }
}
