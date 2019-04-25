using NUnit.Framework;
using TestEnvironment.CodeSignal.Interview;

namespace TestEnvironmentUnitTests.CodeSignal.Interview
{
  [TestFixture]
  [Timeout(3000)]
  public class LinkedListsTests
  {
    [Test]
    public void IsListPalindromeTest01()
    {
      ListNode<int> l = new ListNode<int>()
      {
        value = 0,
        next = new ListNode<int>()
        {
          value = 1,
          next = new ListNode<int>()
          {
            value = 0
          }
        }
      };

      bool isListPalindrome = LinkedLists.IsListPalindrome(l);
      
      Assert.IsTrue(isListPalindrome);
    }
    
    [Test]
    public void IsListPalindromeTest03()
    {
      ListNode<int> l = new ListNode<int>()
      {
        value = 1,
        next = new ListNode<int>()
        {
          value = 1000000000,
          next = new ListNode<int>()
          {
            value = -1000000000,
            next = new ListNode<int>()
            {
              value = -1000000000,
              next = new ListNode<int>()
              {
                value = 1000000000,
                next = new ListNode<int>()
                {
                  value = 1
                }
              }
            }
          }
        }
      };

      bool isListPalindrome = LinkedLists.IsListPalindrome(l);
      
      Assert.IsTrue(isListPalindrome);
    }
  }
}