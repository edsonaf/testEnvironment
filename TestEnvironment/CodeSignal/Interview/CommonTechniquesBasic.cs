namespace TestEnvironment.Interview
{
  public static class CommonTechniquesBasic
  {
    /// <summary>
    /// You have an array of integers nums and an array queries, where queries[i] is a pair of indices
    /// (0-based). Find the sum of the elements in nums from the indices at queries[i][0] to
    /// queries[i][1] (inclusive) for each query, then add all of the sums for all the queries
    /// together. Return that number modulo 10^9 + 7. 
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public static int SumInRange(int[] nums, int[][] queries)
    {
      int sum = 0;
      foreach (var t in queries)
      {
        int begin = t[0];
        int end = t[1];
        for (int j = begin; j < end; j++)
        {
          sum += nums[j];
        }
      }

      return sum % 1000000007;
    }
  }
}