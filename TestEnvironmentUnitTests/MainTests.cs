using NUnit.Framework;
using NUnit.Framework.Internal;
using TestEnvironment;

namespace TestEnvironmentUnitTests
{
  [TestFixture]
  public class MainTests
  {
    [Test]
    public void AlternatingSort_Test01()
    {
      int[] a = {1, 3, 5, 6, 4, 2};
      var main = new Main();
      var alternatingSort = main.AlternatingSort(a);

      Assert.IsTrue(alternatingSort);
    }

    [Test]
    [Ignore("")]
    public void AlternatingSort_Test03()
    {
      int[] a = {1};
      var main = new Main();
      var alternatingSort = main.AlternatingSort(a);

      Assert.IsTrue(alternatingSort);
    }

    [Test]
    public void AlternatingSort_Test05()
    {
      int[] a = {-89, -47, -38, 39, 82, 87, 40, -9, -41, -68};
      var main = new Main();
      var alternatingSort = main.AlternatingSort(a);

      Assert.IsFalse(alternatingSort);
    }

    [Test]
    public void CountTinyPairsTest01()
    {
      int[] a = new[] {1, 2, 3};
      int[] b = new[] {1, 2, 3};
      int k = 31;

      var main = new Main();
      var result = main.countTinyPairs(a, b, k);

      Assert.AreEqual(2, result);
    }

    [Test]
    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest01")]
//    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest02")]
//    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest03")]
//    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest04")]
//    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest05")]
//    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest06")]
//    [TestCase("aabeefegeeccrr", 3, ExpectedResult = 3, TestName = "UpToKDifferencesTest07")]
    [TestCase("abcd", 12, ExpectedResult = 1, TestName = "UpToKDifferencesTest08")]
    [TestCase("abbdartatrbdarratbbdadbbarbdtta", 5, ExpectedResult = 1, TestName = "UpToKDifferencesTest09")]
    [TestCase("bbcdadarbdddaassa", 1, ExpectedResult = 12, TestName = "UpToKDifferencesTest10")]
    [TestCase("qkkkkeqkkkkkkkkkkkkkqqkkqeqkkkqkeeekee", 2, ExpectedResult = 6, TestName = "UpToKDifferencesTest11")]
    [TestCase("ttqqddaearftdassataqdqarttdartfartq", 4, ExpectedResult = 7, TestName = "UpToKDifferencesTest12")]
    [TestCase("eabttrbabatggtrrrrcdggtcgtrttdzxxzcxvvczxxeez", 5, ExpectedResult = 3,
      TestName = "UpToKDifferencesTest13")]
    [TestCase("bhaeibebbediiaicjicdiiehd", 6, ExpectedResult = 2, TestName = "UpToKDifferencesTest14")]
    public int UpToKDifferencesTest(string str, int k)
    {
      var main = new Main();
      return main.upToKDifferences(str, k);
    }


    [Test]
    [TestCase(new[] {10, 2}, ExpectedResult = 1344, TestName = "ConcatenationsSumTest01")]
    [TestCase(new[] {8}, ExpectedResult = 88, TestName = "ConcatenationsSumTest02")]
    [TestCase(new[] {1, 2, 3}, ExpectedResult = 198, TestName = "ConcatenationsSumTest03")]
    [TestCase(new[] {1000000, 1000000, 1000000, 1000000}, ExpectedResult = 160000016000000,
      TestName = "ConcatenationsSumTest04")]
    [TestCase(new[] {987153, 239178, 389649, 469261, 130806}, ExpectedResult = 11080246080235,
      TestName = "ConcatenationsSumTest05")]
//    [TestCase(new[] {}, ExpectedResult = , TestName ="ConcatenationsSumTest06")]
//    [TestCase(new[] {}, ExpectedResult = , TestName ="ConcatenationsSumTest07")]
//    [TestCase(new[] {}, ExpectedResult = , TestName ="ConcatenationsSumTest08")]
    public long ConcatenationsSum(int[] a)
    {
      var main = new Main();
      return main.ConcatenationsSum(a);
    }

    [Test]
    [TestCase(2, 5, ExpectedResult = 1, TestName = "SpecialPolynomialTest01")]
    [TestCase(10, 111111110, ExpectedResult = 7, TestName = "SpecialPolynomialTest02")]
    [TestCase(1, 100, ExpectedResult = 99, TestName = "SpecialPolynomialTest03")]
    [TestCase(3, 140, ExpectedResult = 4, TestName = "SpecialPolynomialTest04")]
    public int SpecialPolynomialTest(int x, int n)
    {
      var main = new Main();
      return main.SpecialPolynomial(x, n);
    }
  }
}