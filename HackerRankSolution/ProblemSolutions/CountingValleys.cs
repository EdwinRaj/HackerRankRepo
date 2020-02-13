using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions
{
    public class CountingValleys
    {
        public static int CountingValleysSolution(int n, string s)
        {
            int stepCounter = 0, previousStepCounter = 0 ;
            bool isFirstStep = true;
            int valleyCount = 0;

            foreach (var step in s)
            {
                if(!isFirstStep)
                {
                    previousStepCounter = stepCounter;
                }


                if (step.ToString().ToLowerInvariant() == "u")
                {
                    stepCounter += 1;
                }
                else
                {
                    stepCounter -= 1;
                }

                if (isFirstStep)
                {
                    isFirstStep = false;
                    continue;
                }
                
                if (previousStepCounter< 0 && stepCounter == 0)
                {
                    valleyCount += 1;
                }
            }

            return valleyCount;
        }

        public static int CountingValleysSmart(int n, string s)
        {
            int valleyCount=0,stepCounter=0;

            foreach (var step in s)
            {

                if (step.ToString().ToLowerInvariant() == "u")
                {
                    stepCounter += 1;
                }
                else
                {
                    stepCounter -= 1;
                }

                if (step == 'U' && stepCounter == 0)
                {
                    valleyCount += 1;
                }
            }

            return valleyCount;
        }
    }
}
