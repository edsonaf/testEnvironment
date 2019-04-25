namespace TestEnvironment.CompanyChallenges
{
  public static class CodeSignalChallenges
  {
    public static double CompanyBotStrategy(int[][] trainingData)
    {
      int amountOfTrainersCorrect = 0;
      double totalAnswerTimeForCorrect = 0;

      // for each trainer
      foreach (int[] t in trainingData)
      {
        if (t[1] != 1)
          continue;

        amountOfTrainersCorrect++;
        totalAnswerTimeForCorrect += t[0];
      }

      return amountOfTrainersCorrect == 0 ? 0 : totalAnswerTimeForCorrect / amountOfTrainersCorrect;
    }


    public static string[] taskMaker(string[] source, int challengeId)
    {
      
      return null;
    }
  }
}