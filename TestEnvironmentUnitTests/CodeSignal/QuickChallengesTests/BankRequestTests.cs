using NUnit.Framework;
using TestEnvironment.QuickChallenges;

namespace TestEnvironmentUnitTests.QuickChallengesTests
{
  [TestFixture]
  [Timeout(3000)]
  public class BankRequestTests
  {
    [Test]
    public void BankRequestTest01()
    {
      // Arrange
      string[] requests =
      {
        "withdraw 2 10", "transfer 5 1 20",
        "deposit 5 20", "transfer 3 4 15"
      };

      int[] accounts = {10, 100, 20, 50, 30};
      int[] expectedResult = {30, 90, 5, 65, 30};

      // Act
      int[] actualResult = BankRequestChallenge.BankRequests(accounts, requests);

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void BankRequestTest04()
    {
      // Arrange
      string[] requests =
      {
        "transfer 1 2 3"
      };

      int[] accounts = {42};
      int[] expectedResult = {-1};

      // Act
      int[] actualResult = BankRequestChallenge.BankRequests(accounts, requests);

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void BankRequestTest06()
    {
      // Arrange
      string[] requests =
      {
        "deposit 11 6",
        "transfer 2 6 91",
        "deposit 10 58",
        "transfer 5 3 49",
        "withdraw 8 40",
        "withdraw 6 67",
        "transfer 7 6 44",
        "withdraw 5 7",
        "transfer 8 2 20",
        "transfer 9 2 94"
      };

      int[] accounts =
      {
        77367, 85558, 88570, 98242, 46552,
        2772, 64226, 72128, 15176, 93254
      };

      int[] expectedResult = {-1};

      // Act
      int[] actualResult = BankRequestChallenge.BankRequests(accounts, requests);

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void BankRequestTest08()
    {
      // Arrange
      string[] requests =
      {
        "deposit 10 93",
        "transfer 10 3 81",
        "deposit 4 4",
        "transfer 8 3 35",
        "withdraw 5 53",
        "transfer 10 4 4",
        "deposit 8 10",
        "transfer 2 6 56",
        "withdraw 4 98",
        "transfer 1 2 60"
      };

      int[] accounts =
      {
        61399, 16119, 78677, 19385, 53, 56692, 5824, 12054, 88354, 89495
      };

      int[] expectedResult = {61339, 16123, 78793, 19295, 0, 56748, 5824, 12029, 88354, 89503};

      // Act
      int[] actualResult = BankRequestChallenge.BankRequests(accounts, requests);

      // Assert
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}