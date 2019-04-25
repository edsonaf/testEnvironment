using NUnit.Framework;

namespace TestEnvironmentUnitTests.Interview
{
  [TestFixture]
  public class HashTablesTests
  {
    [Test]
    public void Test01()
    {
      string[][] dishes = 
      {
        new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"},
        new[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough"},
        new[] {"Quesadilla", "Chicken", "Cheese", "Sauce"},
        new[] {"Sandwich", "Salad", "Bread", "Tomato", "Cheese"}
      };

      string[][] expectedOutput =
      {
        new[] {"Cheese", "Quesadilla", "Sandwich"},
        new[] {"Salad", "Salad", "Sandwich"},
        new[] {"Sauce", "Pizza", "Quesadilla", "Salad"},
        new[] {"Tomato", "Pizza", "Salad", "Sandwich"}
      };

      string[][] output = TestEnvironment.Interview.HashTables.GroupingDishes(dishes);
    }
  }
}