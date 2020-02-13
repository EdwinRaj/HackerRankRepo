using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions
{
    public class SockMerchant
    {
        public static int SockMerchantPairs(int n, int[] ar)
        {
            Dictionary<int, int> pairCount = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if(pairCount.ContainsKey(ar[i]))
                {
                    pairCount[ar[i]] += 1;
                }
                else
                {
                    pairCount[ar[i]] = 1;
                }
            }

            int totalCount = 0;
            foreach (var item in pairCount)
            {
                totalCount += item.Value / 2;
            }

            return totalCount;
        }
    }
}
