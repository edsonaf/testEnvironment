using NUnit.Framework;
using TestEnvironment.CodeSignal.CompanyChallenges;

namespace TestEnvironmentUnitTests.CodeSignal.CompanyChallenges
{
  [TestFixture]
  [Timeout(3000)]
  public class WizelineChallengesTests
  {
    #region CountAPI

    [Test]
    public void CountApiTest01()
    {
      // arrange
      string[] calls =
      {
        "/project1/subproject1/method1",
        "/project2/subproject1/method1",
        "/project1/subproject1/method1",
        "/project1/subproject2/method1",
        "/project1/subproject1/method2",
        "/project1/subproject2/method1",
        "/project2/subproject1/method1",
        "/project1/subproject2/method1"
      };

      string[] expectedResult =
      {
        "--project1 (6)",
        "----subproject1 (3)",
        "------method1 (2)",
        "------method2 (1)",
        "----subproject2 (3)",
        "------method1 (3)",
        "--project2 (2)",
        "----subproject1 (2)",
        "------method1 (2)"
      };

      // act
      string[] result = WizelineChallenges.CountApi(calls);

      // assert
      Assert.AreEqual(expectedResult, result);
    }


    [Test]
    public void CountApiTest02()
    {
      // arrange
      string[] calls =
      {
        "/project3/subproject/method",
        "/project1/subproject/method",
        "/project2/subproject/method"
      };

      string[] expectedResult =
      {
        "--project3 (1)",
        "----subproject (1)",
        "------method (1)",
        "--project1 (1)",
        "----subproject (1)",
        "------method (1)",
        "--project2 (1)",
        "----subproject (1)",
        "------method (1)"
      };

      // act
      string[] result = WizelineChallenges.CountApi(calls);

      // assert
      Assert.AreEqual(expectedResult, result);
    }


    [Test]
    public void CountApiTest03()
    {
      // arrange
      string[] calls =
      {
        "/project/subproject1/methods",
        "/project/subproject1/method",
        "/project/subproject2/method",
        "/project/subproject3/method",
        "/project/subproject2/method",
        "/project/subproject4/method",
        "/project/subproject2/method",
        "/project/subproject4/method2",
        "/project/subproject4/method1",
        "/project/subproject1/methods",
        "/project/subproject4/method1",
        "/project/subproject2/method",
        "/project/subproject4/method",
        "/project/subproject2/method",
        "/project/subproject1/methods"
      };

      string[] expectedResult =
      {
        "--project (15)",
        "----subproject1 (4)",
        "------methods (3)",
        "------method (1)",
        "----subproject2 (5)",
        "------method (5)",
        "----subproject3 (1)",
        "------method (1)",
        "----subproject4 (5)",
        "------method (2)",
        "------method2 (1)",
        "------method1 (2)"
      };

      // act
      string[] result = WizelineChallenges.CountApi(calls);

      // assert
      Assert.AreEqual(expectedResult, result);
    }


    [Test]
    public void CountApiTest04()
    {
      // arrange
      string[] calls =
      {
        "/project5/subproject2/method5",
        "/project3/subproject5/method4",
        "/project4/subproject1/method4",
        "/project4/subproject3/method3",
        "/project5/subproject1/method2",
        "/project2/subproject2/method1",
        "/project3/subproject1/method4",
        "/project1/subproject2/method5",
        "/project2/subproject1/method2",
        "/project1/subproject3/method3",
        "/project2/subproject1/method8",
        "/project3/subproject3/method3",
        "/project1/subproject1/method10",
        "/project1/subproject3/method3",
        "/project2/subproject1/method9",
        "/project5/subproject2/method3",
        "/project5/subproject2/method5",
        "/project5/subproject1/method7",
        "/project5/subproject1/method9",
        "/project1/subproject1/method5"
      };

      string[] expectedResult =
      {
        "--project5 (6)",
        "----subproject2 (3)",
        "------method5 (2)",
        "------method3 (1)",
        "----subproject1 (3)",
        "------method2 (1)",
        "------method7 (1)",
        "------method9 (1)",
        "--project3 (3)",
        "----subproject5 (1)",
        "------method4 (1)",
        "----subproject1 (1)",
        "------method4 (1)",
        "----subproject3 (1)",
        "------method3 (1)",
        "--project4 (2)",
        "----subproject1 (1)",
        "------method4 (1)",
        "----subproject3 (1)",
        "------method3 (1)",
        "--project2 (4)",
        "----subproject2 (1)",
        "------method1 (1)",
        "----subproject1 (3)",
        "------method2 (1)",
        "------method8 (1)",
        "------method9 (1)",
        "--project1 (5)",
        "----subproject2 (1)",
        "------method5 (1)",
        "----subproject3 (2)",
        "------method3 (2)",
        "----subproject1 (2)",
        "------method10 (1)",
        "------method5 (1)"
      };

      // act
      string[] result = WizelineChallenges.CountApi(calls);

      // assert
      Assert.AreEqual(expectedResult, result);
    }


    [Test]
    public void CountApiTest05()
    {
      // arrange
      string[] calls =
      {
        "/main/subproject3/method2",
        "/main/subproject3/method2",
        "/project5/subproject2/method5",
        "/project4/subproject1/method2",
        "/project3/subproject3/method1",
        "/project3/subproject1/method10",
        "/project4/subproject1/method2",
        "/project3/subproject2/method3",
        "/project2/subproject7/method3",
        "/main/subproject6/method5"
      };

      string[] expectedResult =
      {
        "--main (3)",
        "----subproject3 (2)",
        "------method2 (2)",
        "----subproject6 (1)",
        "------method5 (1)",
        "--project5 (1)",
        "----subproject2 (1)",
        "------method5 (1)",
        "--project4 (2)",
        "----subproject1 (2)",
        "------method2 (2)",
        "--project3 (3)",
        "----subproject3 (1)",
        "------method1 (1)",
        "----subproject1 (1)",
        "------method10 (1)",
        "----subproject2 (1)",
        "------method3 (1)",
        "--project2 (1)",
        "----subproject7 (1)",
        "------method3 (1)"
      };

      // act
      string[] result = WizelineChallenges.CountApi(calls);

      // assert
      Assert.AreEqual(expectedResult, result);
    }

    #endregion CountAPI


    #region ChatBot

    [Test]
    public void ChatBotTest01()
    {
      // Arrange
      string[][] conversations =
      {
        new[] {"where", "are", "you", "live", "i", "live", "in", "new", "york"},
        new[] {"are", "you", "going", "somewhere", "tonight", "no", "i", "am", "too", "tired", "today"},
        new[] {"hello", "what", "is", "your", "name", "my", "name", "is", "john"}
      };

      string[] currentConversation =
      {
        "hello", "john", "do", "you", "have", "a", "favorite", "city",
        "to", "live", "in", "yes", "it", "is"
      };

      string[] expectedResult =
      {
        "hello", "john", "do", "you", "have", "a", "favorite", "city",
        "to", "live", "in", "yes", "it", "is", "new", "york"
      };

      // Act
      string[] actual = WizelineChallenges.ChatBot2(conversations, currentConversation);

      // Assert
      Assert.AreEqual(expectedResult, actual);
    }


    [Test]
    public void ChatBotTest02()
    {
      // Arrange
      string[][] conversations = new[]
      {
        new[] {"lets", "have", "some", "fun"},
        new[] {"i", "never", "get", "it"},
        new[] {"be", "aware", "of", "this", "house"},
        new[] {"he", "will", "call", "her"}
      };

      string[] currentConversation = new[]
      {
        "can",
        "you",
        "please"
      };

      string[] expectedResult = new[]
      {
        "can",
        "you",
        "please"
      };

      // Act
      string[] actual = WizelineChallenges.ChatBot2(conversations, currentConversation);

      // Assert
      Assert.AreEqual(expectedResult, actual);
    }


    [Test]
    public void ChatBotTest03()
    {
      // Arrange
      string[][] conversations = new[]
      {
        new[] {"it", "is", "my", "favorite", "movie"},
        new[] {"really", "i", "did", "not", "know"}
      };

      string[] currentConversation = new[]
      {
        "what",
        "you",
        "think",
        "about",
        "this",
        "movie"
      };

      string[] expectedResult = new[]
      {
        "what",
        "you",
        "think",
        "about",
        "this",
        "movie"
      };

      // Act
      string[] actual = WizelineChallenges.ChatBot2(conversations, currentConversation);

      // Assert
      Assert.AreEqual(expectedResult, actual);
    }


    [Test]
    public void ChatBotTest04()
    {
      // Arrange
      string[][] conversations = new[]
      {
        new[] {"tonight", "i", "need", "dollar", "bills"},
        new[] {"i", "dont", "keep", "fun"},
        new[] {"cheap", "thrills", "long", "to", "feel", "money"},
        new[] {"the", "bills", "dont", "need", "the", "dancing", "baby"},
        new[] {"fun", "dollar", "dancing", "thrills", "the", "baby", "i", "need"},
        new[] {"dont", "have", "fun"},
        new[] {"no", "no", "dont", "have", "dancing", "fun", "tonight"},
      };

      string[] currentConversation = new[]
      {
        "beat",
        "the",
        "can",
        "as",
        "i",
        "dont",
        "feel",
        "thrills"
      };

      string[] expectedResult = new[]
      {
        "beat",
        "the",
        "can",
        "as",
        "i",
        "dont",
        "feel",
        "thrills",
        "need"
      };

      // Act
      string[] actual = WizelineChallenges.ChatBot2(conversations, currentConversation);

      // Assert
      Assert.AreEqual(expectedResult, actual);
    }


    [Test]
    public void ChatBotTest05()
    {
      // Arrange
      string[][] conversations = new[]
      {
        new[] {"fame", "what", "you", "like", "is", "in", "the", "limo"},
        new[] {"fame", "what", "you", "get", "is", "no", "tomorrow"},
        new[] {"fame", "what", "you", "need", "you", "have", "to", "borrow", "fame"},
        new[] {"fame", "its", "mine", "its", "mine", "its", "just", "his", "line"},
        new[] {"to", "bind", "your", "time", "it", "drives", "you", "to", "crime"},
      };

      string[] currentConversation = new[]
      {
        "what", "is"
      };

      string[] expectedResult = new[]
      {
        "what",
        "is",
        "in",
        "the",
        "limo"
      };

      // Act
      string[] actual = WizelineChallenges.ChatBot2(conversations, currentConversation);

      // Assert
      Assert.AreEqual(expectedResult, actual);
    }

    #endregion ChatBot


    #region RoadMap

    [Test]
    public void RoadMapTest01()
    {
      // Arrange
      string[][] tasks = new string[3][];
      tasks[0] = new[] {"A", "2017-02-01", "2017-03-01", "Sam", "Evan", "Troy"};
      tasks[1] = new[] {"B", "2017-01-16", "2017-02-15", "Troy"};
      tasks[2] = new[] {"C", "2017-02-13", "2017-03-13", "Sam", "Evan"};

      string[][] queries = new string[2][];
      queries[0] = new[] {"Evan", "2017-03-10"};
      queries[1] = new[] {"Troy", "2017-02-04"};

      string[][] expectedOutput = new string[2][];
      expectedOutput[0] = new[] {"C"};
      expectedOutput[1] = new[] {"B", "A"};

      // Act
      string[][] roadMap = WizelineChallenges.RoadMap(tasks, queries);

      // Assert
      Assert.AreEqual(expectedOutput, roadMap);
    }

    #endregion RoadMap
  }
}