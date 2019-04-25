using System.Linq;

namespace TestEnvironment.CodeSignal.CompanyChallenges.VerkadaChallenges
{
  /// <assignment>
  /// Your Verkada security camera has captured a funny video of a hummingbird. You'd like to post the clip on your
  /// social media account, but there were some people visible in the background. Since the image on a Verkada camera
  /// is so sharp and crisp, their faces are clearly identifiable, which you think might be an invasion of privacy.
  /// So you've decided to blur their faces before posting the clip
  /// You are given an image, represented as a matrix of integers, where each integer corresponds to a color. The
  /// number in the ith (0-based) row and jth (0-based) column represents the color of the pixel in the ith row and
  /// jth column of the image.
  /// Your task is to blur the image. In order to do that, you need to replace each number of the matrix with the
  /// average of the numbers in the neighboring cells. We assume that two cells are neighbors if they share at least
  /// one corner. The cell itself is not considered part of the average; only the 8 surrounding neighbors (or fewer
  /// if the cell is against an edge).
  /// </assignment>
  public static class VerkadaBlurFaces
  {
    public static double[][] BlurFaces(int[][] img)
    {
      double[][] output = new double[img.Length][];

      for (int i = 0; i < img.Length; i++)
      {
        output[i] = img[0].Select(x => (double) x).ToArray();
        for (int j = 0; j < img[i].Length; j++)
        {
          bool hasLeftTop = i - 1 >= 0 && j - 1 >= 0;
          bool hasRightTop = i - 1 >= 0 && j + 1 < img[i].Length;

          bool hasTop = i - 1 >= 0;
          bool hasLeft = j - 1 >= 0;
          bool hasRight = j + 1 < img[i].Length;
          bool hasBot = i + 1 < img.Length;

          bool hasLeftBot = i + 1 < img.Length && j - 1 >= 0;
          bool hasRightBot = i + 1 < img.Length && j + 1 < img[i].Length;

          int count = 0;
          int sum = 0;

          if (hasLeftTop)
          {
            count++;
            sum += img[i - 1][j - 1];
          }

          if (hasRightTop)
          {
            count++;
            sum += img[i - 1][j + 1];
          }

          if (hasTop)
          {
            count++;
            sum += img[i - 1][j];
          }

          if (hasLeft)
          {
            count++;
            sum += img[i][j - 1];
          }

          if (hasRight)
          {
            count++;
            sum += img[i][j + 1];
          }

          if (hasBot)
          {
            count++;
            sum += img[i + 1][j];
          }

          if (hasLeftBot)
          {
            count++;
            sum += img[i + 1][j - 1];
          }

          if (hasRightBot)
          {
            count++;
            sum += img[i + 1][j + 1];
          }

          output[i][j] = (double) sum / count;
        }
      }

      return output;
    }
  }
}