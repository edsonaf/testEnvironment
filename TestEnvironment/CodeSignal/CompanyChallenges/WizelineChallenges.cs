using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment.CodeSignal.CompanyChallenges
{
  public static class WizelineChallenges
  {
    /// <summary>
    /// You are given a list of API calls in the format /project/subproject/method. You need to calculate and print the
    /// number of calls to each node of the API endpoint as a tree.
    /// In this tree, projects, subprojects, and methods should be sorted in the same order as they were given in the
    /// input data. The output tree should consist of several strings. All subprojects fall under their parent project,
    /// and all methods fall under the subproject in which they are included. The string that represents a project
    /// starts with --, while subprojects start with ---- and methods start with ------. After the project, subproject,
    /// or method name, put the number of requests to this module in parentheses. Take a look at the example for a
    /// guide of what this tree should look like.
    /// </summary>
    /// <param name="calls"></param>
    /// <returns></returns>
    public static string[] CountApi(string[] calls)
    {
      List<string[]> listOfCalls = calls.Select(t => t.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries)).ToList();
      string result = "";

      foreach (var call in listOfCalls.GroupBy(x => x[0]))
      {
        result += $"--{call.Key} ({call.Count()})\n";

        foreach (var sub1 in call.GroupBy(s => s[1]))
        {
          result += $"----{sub1.Key} ({sub1.Count()})\n";

          foreach (var sub2 in sub1.GroupBy(s => s[2]))
          {
            result += $"------{sub2.Key} ({sub2.Count()})\n";
          }
        }
      }

      return result.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
    }


    /// <summary>
    /// You have a list of conversations, in which each element is a conversation that is represented as an array of
    /// words. You need to create a ChatBot that will complete a conversation that is currently in progress,
    /// currentConversation.
    /// To do that, the ChatBot must find the conversation from the given list that has the largest number of unique
    /// words that match with words from the currentConversation. If there are several conversations that match this
    /// condition, the ChatBot should use the one that appears first in conversations. If no conversation from the list
    /// contains any matching words from currentConversation, the ChatBot should leave currentConversation as it is.
    /// If there is a conversation that can complete currentConversation, the ChatBot should find the first word in it
    /// that appears after all the matching words. The ChatBot should then append this word, along with all the words
    /// that follow it in that conversation, to currentConversation.
    /// Return the final state of currentConversation.
    /// </summary>
    /// <returns></returns>
    public static string[] ChatBot(string[][] conversations, string[] currentConversation)
    {
      int[] matchCounts = new int[conversations.Length];
      int[] lastMatchedStringIndex = new int[conversations.Length];

      for (int i = 0; i < conversations.Length; i++)
      {
        IEnumerable<string> enumerable = conversations[i].Distinct();
        int count = enumerable.Intersect(currentConversation).Count();
        IEnumerable<int> @select = conversations[i].Select((value, index) => new {value, index})
          .Where(v => currentConversation.Max(s => string.Equals(v.value, s)))
          .Select(v => v.index);
        matchCounts[i] = count;
        lastMatchedStringIndex[i] = @select.LastOrDefault() + 1;
      }

      if (matchCounts.All(m => m == 0)) return currentConversation;

      int max = matchCounts.Max(t => t);
      int indexOf = Array.IndexOf(matchCounts, max);

      string[] newCurrentConversation = currentConversation;
      int arrayCount = currentConversation.Length;
      Array.Resize(ref newCurrentConversation, arrayCount + (conversations[indexOf].Length - lastMatchedStringIndex[indexOf]));
      for (int i = lastMatchedStringIndex[indexOf]; i < conversations[indexOf].Length; i++)
      {
        newCurrentConversation[arrayCount++] = conversations[indexOf][i];
      }

      return newCurrentConversation;
    }

    public static string[] ChatBot2(string[][] conversations, string[] currentConversation)
    {
      string[] uniqueWords = currentConversation.Distinct().ToArray();

      int conversationIndex = -1;
      int maxLastWordIndex = 0;
      int maxMatchingWords = 0;

      for (int i=0; i<conversations.Length; i++)
      {
        int matchingWords = -1;
        int lastWordIndex = -1;

        if (maxMatchingWords >= uniqueWords.Length)
        {
          continue;
        }
        
        foreach (string t in uniqueWords)
        {
          for(int k=conversations[i].Length-1; k>=0; k--)
          {
            if (conversations[i][k] != t)
            {
              continue;
            }

            //Console.WriteLine("FOUNDONE");
            matchingWords++;
            if (k > lastWordIndex)
            {
              lastWordIndex = k;
            }
            break;
          }
        }

        if (matchingWords <= maxMatchingWords)
        {
          continue;
        }

        conversationIndex = i;
        maxLastWordIndex = lastWordIndex;
        maxMatchingWords = matchingWords;
      }

      if (conversationIndex < 0)
      {
        return currentConversation;
      }

      {
        List<string> al = new List<string>(currentConversation);
        for (int i=maxLastWordIndex+1; i<conversations[conversationIndex].Length; i++)
        {
          al.Add(conversations[conversationIndex][i]);
        }
        return al.ToArray();
      }

    }

    /// <summary>
    /// You have a RoadMap, which is the list of tasks that your team needs to complete. Each task in this list has a
    /// title, a start date, an end date, and a list of the people who will be working on it. You are given some
    /// queries, each of which contains a specific person's name and a date. For each query that is made, you need to
    /// return the list of tasks on which that person will be working on the date specified in the query, sorted by the
    /// tasks' end dates. If their end dates are equal, then sort by the tasks' titles.
    /// 
    /// </summary>
    /// <param name="tasks"></param>
    /// <param name="queries"></param>
    /// <returns></returns>
    public static string[][] RoadMap(string[][] tasks, string[][] queries)
    {
      string[][] result = new string[queries.Length][];

      for (int i = 0; i < queries.Length; i++)
      {
        string person = queries[i][0];
        DateTime date = DateTime.Parse(queries[i][1]);
        result[i] = new string[0];

        Dictionary<string, DateTime> resultTaskForPerson = new Dictionary<string, DateTime>();
        foreach (string[] t in tasks)
        {
          List<string> list = t.ToList();
          string taskTitle = t[0];
          DateTime beginDate = DateTime.Parse(t[1]);
          DateTime endDate = DateTime.Parse(t[2]);

          if (date >= beginDate && date <= endDate && list.Contains(person))
          {
            resultTaskForPerson.Add(taskTitle, endDate);
          }
        }

        if (resultTaskForPerson.Count > 0)
        {
          result[i] = resultTaskForPerson.OrderBy(d => d.Value).ThenBy(d => d.Key).Select(r => r.Key).ToArray();
        }
      }

      return result;
    }
  }
}