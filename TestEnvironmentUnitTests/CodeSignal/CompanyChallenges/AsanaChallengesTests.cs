using NUnit.Framework;
using TestEnvironment.CodeSignal.CompanyChallenges;

namespace TestEnvironmentUnitTests.CodeSignal.CompanyChallenges
{
  [TestFixture]
  [Timeout(3000)]
  public class AsanaChallengesTests
  {
    [TestCase(new[] {1, 2, 3, 4, 5}, 2, ExpectedResult = new[] {2, 3, 0})]
    [TestCase(new[] {1, 2, 4, 2, 10, 3, 1, 4, 5, 4, 9, 8}, 1, ExpectedResult = new[] {2, 8, 2})]
    [TestCase(new[] {1}, 1, ExpectedResult = new[] {1, 0, 0})]
    [TestCase(new[] {8}, 7, ExpectedResult = new[] {0, 1, 0})]
    [TestCase(new[] {4, 14, 16}, 7, ExpectedResult = new[] {1, 1, 1})]
    public int[] TasksTypesTest(int[] deadlines, int today)
    {
      return AsanaChallenges.TasksTypes(deadlines, today);
    }


    [Test]
    public void SmartAssigningTest01()
    {
      // arrange
      string[] names = {"John", "Martin"};
      bool[] statuses = {false, false};
      int[] projects = {2, 1};
      int[] tasks = {16, 5};

      string expected = "Martin";

      // act
      string smartAssigning = AsanaChallenges.SmartAssigning(names, statuses, projects, tasks);

      // assert
      Assert.AreEqual(expected, smartAssigning);
    }


    [Test]
    public void SmartAssigningTest05()
    {
      // arrange
      string[] names = {"John", "Martin", "Luke"};
      bool[] statuses = {false, true, false};
      int[] projects = {1, 0, 2};
      int[] tasks = {2, 0, 1};

      string expected = "Luke";

      // act
      string smartAssigning = AsanaChallenges.SmartAssigning(names, statuses, projects, tasks);

      // assert
      Assert.AreEqual(expected, smartAssigning);
    }


    #region TaskScheduling
    
    [Test]
    public void TaskSchedulingTest02()
    {
      // arrange
      int workingHours = 3;
      int[] tasks = {2, 2, 2};
      int expected = 3;

      // act
      int tasksScheduling = AsanaChallenges.TasksScheduling(workingHours, tasks);

      // assert
      Assert.AreEqual(expected, tasksScheduling);
    }

    [Test]
    public void TaskSchedulingTest05()
    {
      // arrange
      int workingHours = 15;
      int[] tasks = {4, 15, 6, 3, 13, 4, 7, 14, 8, 15, 5, 8};
      int expected = 7;

      // act
      int tasksScheduling = AsanaChallenges.TasksScheduling(workingHours, tasks);

      // assert
      Assert.AreEqual(expected, tasksScheduling);
    }

    [Test]
    public void TaskSchedulingTest12()
    {
      // arrange
      int workingHours = 10;
      int[] tasks = {9};
      int expected = 1;

      // act
      int tasksScheduling = AsanaChallenges.TasksScheduling(workingHours, tasks);

      // assert
      Assert.AreEqual(expected, tasksScheduling);
    }

    [Test]
    public void TaskSchedulingTest15()
    {
      // arrange
      int workingHours = 3;
      int[] tasks = {1, 1, 2, 2};
      int expected = 2;

      // act
      int tasksScheduling = AsanaChallenges.TasksScheduling(workingHours, tasks);

      // assert
      Assert.AreEqual(expected, tasksScheduling);
    }
    
    #endregion TaskScheduling
    
  }
}