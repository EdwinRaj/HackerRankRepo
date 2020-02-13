using NUnit.Framework;
using ProblemSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTests
{
    [TestFixture]
    public class HackerRankTests
    {
        [TestCase(9,new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 })]
        [Test]
        public void TestSockMerchant(int n, int[] ar)
        {
            int result = SockMerchant.SockMerchantPairs(n, ar);
            Assert.AreEqual(3, result);
        }

        [TestCase(8, "UDDDUDUU",1)]
        [Test]
        public void TestValleyCount(int n, string map,int expectedResult)
        {
            int result = CountingValleys.CountingValleysSolution(n, map);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
        [Test]
        public void TestCloudJump(int[] clouds, int expectedResult)
        {
            int result = JumpingOnCloud.JumpingOnCloudsSolution(clouds);
            Assert.AreEqual(expectedResult, result);

        }

        [TestCase(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 2)]
        [TestCase(new int[] { 0 }, 1)]
        [TestCase(new int[] { 1,1,1 }, 2)]
        [TestCase(new int[] { 1}, 2)]
        [TestCase(new int[] { -5,-4,-3,1}, 2)]
        [TestCase(new int[] { 10,20,30 }, 1)]
        [TestCase(new int[] { 1,2,3,4,5,6,7,8 }, 9)]
        [Test]
        public void TestSmallestPositiveNumber(int[] A, int expectedResult)
        {
            int result = SmallestMissingPositiveInteger.Solution(A);
            Assert.AreEqual(expectedResult, result);

        }

    }
}
