﻿using NUnit.Framework;
using TestEnvironment.CodeSignal.Interview;

namespace TestEnvironmentUnitTests.CodeSignal.Interview
{
  [TestFixture]
  public class CommonTechniquesBasicTests
  {
    [Test]
    public void Test01()
    {
      int[] nums = {3, 0, -2, 6, -3, 2};
      int[][] queries = {
        new[] {0, 2},
        new[] {2, 5},
        new[] {0, 5}
      };

      int expectedOutput = 10;

      var output = CommonTechniquesBasic.SumInRange(nums, queries);

      Assert.AreEqual(expectedOutput, output);
    }
  }
}