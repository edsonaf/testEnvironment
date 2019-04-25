using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment.CodeSignal.Interview
{
  public static class LinkedLists
  {
    private static ListNode<int> RemoveKFromList(ListNode<int> l, int k)
    {
      string s = "";
      string s1 = s.Reverse().ToString();
      if (l?.value == k)
      {
        l = RemoveKFromList(l?.next, k);
      }

      if (l?.next != null)
      {
        l.next = RemoveKFromList(l?.next, k);
      }

      return l;
    }


    /// <summary>
    /// Given a singly linked list of integers, determine whether or not it's a palindrome.
    /// </summary>
    /// <param name="l"></param>
    /// <returns></returns>
    public static bool IsListPalindrome(ListNode<int> l)
    {
      List<int> list = GetFullList(l);
      List<int> notReversed = new List<int>(list);
      
      list.Reverse();

      int i = 0;
      while (i < list.Count)
      {
        if (list[i] != notReversed[i]) return false;
        i++;
      }

      return true;
    }

    private static List<int> GetFullList(ListNode<int> l)
    {
      List<int> stringList = new List<int>(); 
      if (l?.value != null)
      {
       stringList.Add(l.value);
      }

      if (l?.next != null)
      {
        stringList.AddRange(GetFullList(l.next));
      }

      return stringList;
    }
  }

  // Definition for singly-linked list:
  public class ListNode<T>
  {
    public T value { get; set; }
    public ListNode<T> next { get; set; }
  }
}