﻿using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using TestEnvironment.CodeWars;

namespace TestEnvironmentUnitTests.CodeWars
{
  public class CodeWarsMainTests
  {
    [TestCase("4556364607935616", ExpectedResult = "############5616", TestName = "MaskifyTest01")]
    [TestCase("1", ExpectedResult = "1", TestName = "MaskifyTest02")]
    [TestCase("11111", ExpectedResult = "#1111", TestName = "MaskifyTest03")]
    public string MaskifyTest(string cc)
    {
      return CodeWarsMain.Maskify(cc);
    }

    [TestCase(0, ExpectedResult = true, TestName = "IsSquareTest01")]
    public bool IsSquareTest(int n)
    {
      return CodeWarsMain.IsSquare(n);
    }

    [TestCase(1, 1, ExpectedResult = 1, TestName = "GetSumTest01")]
    public int GetSumTest(int a, int b)
    {
      return CodeWarsMain.GetSum(a, b);
    }
  }
}