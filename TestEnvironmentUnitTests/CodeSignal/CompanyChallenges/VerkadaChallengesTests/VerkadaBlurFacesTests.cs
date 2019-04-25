using System;
using NUnit.Framework;
using TestEnvironment.CompanyChallenges.VerkadaChallenges;

namespace TestEnvironmentUnitTests.CompanyChallenges.VerkadaChallengesTests
{
  [TestFixture]
  [Timeout(3000)]
  public class VerkadaBlurFacesTests
  {
    [Test]
    public void VerkadaBlurFacesTest01()
    {
      // Arrange
      int[][] img = new int[2][];
      img[0] = new[] {1, 4};
      img[1] = new[] {7, 10};

      double[][] expectedOutput = new double[2][];
      expectedOutput[0] = new double[] {7, 6};
      expectedOutput[1] = new double[] {5, 4};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }

      // Why?
      // For img = [[1, 4], [7, 10]], the output should be blurFaces(img) = [[7, 6], [5, 4]].
      //
      // newImg[0][0] = (4 + 7 + 10) / 3 = 21 / 3 = 7
      // newImg[0][1] = (1 + 7 + 10) / 3 = 18 / 3 = 6
      // newImg[1][0] = (1 + 4 + 10) / 3 = 15 / 3 = 5
      // newImg[1][1] = (1 + 4 + 7) / 3 = 12 / 3 = 4
    }


    [Test]
    public void VerkadaBlurFacesTest02()
    {
      // Arrange
      int[][] img = new int[3][];
      img[0] = new[] {3, 0, 2, 5};
      img[1] = new[] {1, 2, 3, 4};
      img[2] = new[] {2, 3, 2, 3};

      double[][] expectedOutput = new double[3][];
      expectedOutput[0] = new[] {1, 2.2, 2.8, 3};
      expectedOutput[1] = new[] {2, 2, 2.625, 3};
      expectedOutput[2] = new double[] {2, 2, 3, 3};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
      // Why

      /*
       *For img = [[3, 0, 2, 5], [1, 2, 3, 4], [2, 3, 2, 3]], the output should be blurFaces(img) =
       * [[1, 2.2, 2.8, 3], [2, 2, 2.625, 3], [2, 2, 3, 3]].
       * newImg[0][0] = (0 + 1 + 2) / 3 = 3 / 3 = 1
       * newImg[0][1] = (1 + 2 + 2 + 3 + 3) / 3 = 11 / 5 = 2.2
       * newImg[0][2] = (0 + 2 + 3 + 4 + 5) / 3 = 14 / 5 = 2.8
       * newImg[0][3] = (2 + 3 + 4) / 3 = 9 / 3 = 3
       * newImg[1][0] = (0 + 2 + 2 + 3 + 3) / 3 = 10 / 5 = 2
       * newImg[1][1] = (0 + 1 + 2 + 2 + 2 + 3 + 3 + 3) / 3 = 16 / 8 = 2
       * newImg[1][2] = (0 + 2 + 2 + 2 + 3 + 3 + 4 + 5) / 3 = 21 / 8 = 2.625
       * newImg[1][3] = (2 + 2 + 3 + 3 + 5) / 3 = 15 / 5 = 3
       * newImg[2][0] = (1 + 2 + 3) / 3 = 6 / 3 = 2
       * newImg[2][1] = (1 + 2 + 2 + 2 + 3) / 3 = 10 / 5 = 2
       * newImg[2][2] = (2 + 3 + 3 + 3 + 4) / 3 = 15 / 5 = 3
       * newImg[2][3] = (2 + 3 + 4) / 3 = 9 / 3 = 3 
       */
    }

    [Test]
    public void VerkadaBlurFacesTest03()
    {
      // Arrange
      int[][] img = new int[2][];
      img[0] = new[] {47, 2, 37, 18, 6};
      img[1] = new[] {10, 12, 25, 24, 21};

      double[][] expectedOutput = new double[2][];
      expectedOutput[0] = new[] {8, 26.2, 16.2, 22.6, 21};
      expectedOutput[1] = new[] {20.3333333333d, 24.2, 18.6, 21.4, 16};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest04()
    {
      // Arrange
      int[][] img = new int[9][];
      img[0] = new[] {2, 8};
      img[1] = new[] {50, 5};
      img[2] = new[] {4, 52};
      img[3] = new[] {50, 2};
      img[4] = new[] {9, 4};
      img[5] = new[] {10, 4};
      img[6] = new[] {4, 4};
      img[7] = new[] {77, 5};
      img[8] = new[] {22, 3};

      double[][] expectedOutput = new double[9][];
      expectedOutput[0] = new double[] {21, 19};
      expectedOutput[1] = new[] {14.2, 23.2};
      expectedOutput[2] = new[] {31.8, 22.2};
      expectedOutput[3] = new[] {14.2, 23.8};
      expectedOutput[4] = new double[] {14, 15};
      expectedOutput[5] = new[] {5, 6.2};
      expectedOutput[6] = new double[] {20, 20};
      expectedOutput[7] = new[] {7.6, 22};
      expectedOutput[8] = new[] {28.3333333333, 34.6666666667};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest05()
    {
      // Arrange
      int[][] img = new int[3][];
      img[0] = new[] {19, 63, 18, 19};
      img[1] = new[] {45, 11, 6, 18};
      img[2] = new[] {8, 23, 9, 17};

      double[][] expectedOutput = new double[3][];
      expectedOutput[0] = new[] {39.6666666667, 19.8, 23.4, 14};
      expectedOutput[1] = new[] {24.8, 23.875, 22.25, 13.8};
      expectedOutput[2] = new[] {26.3333333333, 15.8, 15, 11};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest06()
    {
      // Arrange
      int[][] img = new int[1][];
      img[0] = new[] {3, 3};

      double[][] expectedOutput = new double[1][];
      expectedOutput[0] = new double[] {3, 3};

      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest07()
    {
      // Arrange
      int[][] img = new int[8][];
      img[0] = new[] {2, 14, 1, 14};
      img[1] = new[] {55, 9, 27, 10};
      img[2] = new[] {7, 2, 9, 12};
      img[3] = new[] {6, 4, 2, 9};
      img[4] = new[] {1, 8, 16, 11};
      img[5] = new[] {7, 1, 4, 3};
      img[6] = new[] {32, 16, 26, 29};
      img[7] = new[] {3, 6, 16, 1};


      double[][] expectedOutput = new double[8][];
      expectedOutput[0] = new[] {26, 18.8, 14.8, 12.6666666667};
      expectedOutput[1] = new[] {6.8, 14.625, 8.875, 12.6};
      expectedOutput[2] = new[] {15.2, 14.875, 9.375, 11.4};
      expectedOutput[3] = new[] {4.4, 6.375, 8.875, 10};
      expectedOutput[4] = new[] {5.2, 5.125, 5.25, 6.8};
      expectedOutput[5] = new[] {11.6, 13.75, 13.75, 17.2};
      expectedOutput[6] = new[] {6.6, 11.875, 9.5, 10};
      expectedOutput[7] = new[] {18, 18.6, 15.6, 23.6666666667};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest08()
    {
      // Arrange
      int[][] img = new int[6][];
      img[0] = new[] {29, 14, 6, 13, 4};
      img[1] = new[] {7, 63, 47, 2, 1};
      img[2] = new[] {11, 3, 5, 1, 1};
      img[3] = new[] {1, 10, 9, 4, 2};
      img[4] = new[] {4, 2, 10, 20, 0};
      img[5] = new[] {4, 11, 11, 8, 38};


      double[][] expectedOutput = new double[6][];
      expectedOutput[0] = new[] {28, 30.4, 27.8, 12, 5.33333333333};
      expectedOutput[1] = new[] {24, 15.25, 13.375, 9.75, 4.2};
      expectedOutput[2] = new[] {16.8, 19.125, 17.375, 8.875, 2};
      expectedOutput[3] = new[] {6, 5.625, 6.875, 6, 5.2};
      expectedOutput[4] = new[] {5.6, 7.5, 9.375, 10.25, 14.4};
      expectedOutput[5] = new[] {5.66666666667, 6.2, 10.2, 15.8, 9.33333333333};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest09()
    {
      // Arrange
      int[][] img = new int[7][];
      img[0] = new[] {16, 22, 2, 62, 25, 2};
      img[1] = new[] {1, 1, 5, 3, 1, 7};
      img[2] = new[] {26, 5, 21, 97, 21, 26};
      img[3] = new[] {4, 19, 11, 4, 26, 6};
      img[4] = new[] {10, 27, 30, 4, 6, 1};
      img[5] = new[] {4, 5, 53, 3, 16, 4};
      img[6] = new[] {3, 2, 10, 4, 2, 20};


      double[][] expectedOutput = new double[7][];
      expectedOutput[0] = new[] {8, 5, 18.6, 7.2, 15, 11};
      expectedOutput[1] = new[] {14, 12.25, 26.625, 29.25, 30.375, 15};
      expectedOutput[2] = new[] {6, 11, 18.125, 11.5, 21.25, 12.2};
      expectedOutput[3] = new[] {17.4, 16.75, 25.875, 27, 20.625, 16};
      expectedOutput[4] = new[] {11.8, 17, 15.75, 18.625, 8, 11.6};
      expectedOutput[5] = new[] {9.4, 17.375, 10.625, 15.625, 5.5, 9};
      expectedOutput[6] = new[] {3.66666666667, 15, 13.4, 16.8, 9.4, 7.33333333333};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest10()
    {
      // Arrange
      int[][] img = new int[5][];
      img[0] = new[] {2, 11, 10, 3, 8, 31, 1, 1};
      img[1] = new[] {6, 17, 2, 10, 47, 26, 24, 1};
      img[2] = new[] {2, 7, 0, 12, 3, 65, 18, 7};
      img[3] = new[] {6, 1, 1, 46, 11, 3, 41, 22};
      img[4] = new[] {7, 20, 6, 20, 20, 47, 25, 9};


      double[][] expectedOutput = new double[5][];
      expectedOutput[0] = new[] {11.3333333333, 7.4, 8.6, 15.4, 23.4, 21.2, 16.6, 8.66666666667};
      expectedOutput[1] = new[] {7.8, 5, 8.75, 10.625, 19.75, 24.625, 18.75, 10.2};
      expectedOutput[2] = new[] {7.4, 4.375, 12, 15, 27.5, 21.625, 23.625, 21.2};
      expectedOutput[3] = new[] {7.4, 6.125, 14, 9.125, 27, 28.75, 24.5, 20};
      expectedOutput[4] = new[] {9, 4.2, 17.6, 16.8, 25.4, 20, 24.4, 29.3333333333};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }

    [Test]
    public void VerkadaBlurFacesTest11()
    {
      // Arrange
      int[][] img = new int[7][];
      img[0] = new[] {15, 30, 20, 5};
      img[1] = new[] {7, 3, 1, 7};
      img[2] = new[] {52, 1, 21, 43};
      img[3] = new[] {9, 9, 26, 37};
      img[4] = new[] {80, 33, 7, 11};
      img[5] = new[] {19, 10, 17, 2};
      img[6] = new[] {11, 4, 38, 10};


      double[][] expectedOutput = new double[7][];
      expectedOutput[0] = new[] {13.3333333333, 9.2, 9.2, 9.33333333333};
      expectedOutput[1] = new[] {20.2, 18.375, 16.25, 18};
      expectedOutput[2] = new[] {5.8, 16, 15.875, 18.4};
      expectedOutput[3] = new[] {35, 28.625, 20.25, 21.6};
      expectedOutput[4] = new[] {16, 22.125, 18.125, 17.8};
      expectedOutput[5] = new[] {27.6, 26.125, 14.375, 16.6};
      expectedOutput[6] = new[] {11, 19, 8.6, 19};


      // Act
      double[][] actual = VerkadaBlurFaces.BlurFaces(img);

      // Assert
      for (int i = 0; i < expectedOutput.Length; i++)
      {
        for (int j = 0; j < expectedOutput[i].Length; j++)
        {
          Assert.IsTrue(IsEqualDouble.DoubleIsEqual(expectedOutput[i][j], actual[i][j]));
        }
      }
    }
  }

  public static class IsEqualDouble
  {
    public static bool DoubleIsEqual(double x, double y)
    {
      double epsilon = Math.Max(Math.Abs(x), Math.Abs(y)) * 1E-5;
      return Math.Abs(x - y) <= epsilon;
    }
  }
}