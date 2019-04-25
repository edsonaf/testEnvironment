using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment.CodeSignal.CompanyChallenges
{
  public static class AsanaChallenges
  {
    /// <assignment>
    /// You have some tasks in your Asana account. For each ith of them you know its deadlines(i), which is the last
    /// day  by which it should be completed. As you can see in your calendar, today's date is day. Asana labels each
    /// task in accordance with its due date:
    /// If the task is due today or it's already overdue, it is labeled as Today;
    /// If the task is due within a week but not today - that is, its deadline is somewhere between day + 1 and day
    /// + 7 both inclusive - it is labeled as Upcoming;
    /// All other tasks are labeled as Later;
    /// Given an array of deadlines and today's date day, your goal is to find the number of tasks with each label
    /// type and return it as an array with the format [Today, Upcoming, Later], where Today, Upcoming and Later are
    /// the number of tasks that correspond to that label.
    /// </assignment>
    /// <param name="deadlines"></param>
    /// <param name="day"></param>
    /// <returns></returns>
    public static int[] TasksTypes(int[] deadlines, int day)
    {
      int today = 0;
      int upcoming = 0;
      int later = 0;

      foreach (int t in deadlines)
      {
        if (t <= day)
          today++;

        else if (t >= day + 1 && t <= day + 7)
          upcoming++;

        else
        {
          later++;
        }
      }

      return new[] {today, upcoming, later};
    }


    /// <summary>
    /// Asana is exploring a smart-workload feature designed to streamline task assignment between coworkers. Newly created tasks will be automatically assigned to the team member with the lightest workload. For the ith person, the following information is known:
    /// names(i) - their name, a string containing only uppercase and lowercase letters;
    /// statuses(i) - their vacation indicator status, which is true if the person is on a vacation, or false otherwise;
    /// projects(i) - the number of projects they are currently involved in;
    /// tasks(i) - the number of tasks assigned to them.
    /// If a person's vacation indicator value is set to true, this means they are on vacation and cannot be assigned new tasks. Conversely, a vacation indicator value of false means they are open to receive task assignments.
    /// Asana sorts team members according to their availability. Person A has a higher availability than person B if they have fewer tasks to do than B, or if these numbers are equal but A has fewer assigned projects than B. Put another way, we can say that person A has a higher availability than person B if their (tasks, projects) pair is less than the same pair for B.
    /// Your task is to find the name of the person with the highest availability. It is guaranteed that there is exactly one such person.
    /// 
    /// </summary>
    /// <param name="names"></param>
    /// <param name="statuses"></param>
    /// <param name="projects"></param>
    /// <param name="tasks"></param>
    /// <returns></returns>
    public static string SmartAssigning(string[] names, bool[] statuses, int[] projects, int[] tasks)
    {
      int amount = names.Length;
      Dictionary<string, bool> personVacationStatus = names.ToDictionary(person => person, person => false);
      Dictionary<string, int> personAmountProjects = names.ToDictionary(person => person, person => 0);
      Dictionary<string, int> personAmountTasks = names.ToDictionary(person => person, person => 0);

      for (int i = 0; i < amount; i++)
      {
        personVacationStatus[names[i]] = statuses[i];
        personAmountProjects[names[i]] = projects[i];
        personAmountTasks[names[i]] = tasks[i];
      }

      var peopleOnVacation = personVacationStatus.Where(v => v.Value).Select(d => d.Key).ToList();
      foreach (string s in peopleOnVacation)
      {
        personVacationStatus.Remove(s);
        personAmountProjects.Remove(s);
        personAmountTasks.Remove(s);
      }

      if (personVacationStatus.Count == 1) return personVacationStatus.First().Key;

      var available = personAmountProjects.Where(a => personAmountTasks.Min(t => t.Value) == personAmountTasks[a.Key]).ToList();
      return available.Count > 1 ? available.Where(f => available.Min(a => a.Value) == f.Value).Select(d => d.Key).First() : available.First().Key;
    }


    /// <assignment>
    /// The Asana center pane contains a list of tasks. These tasks are placed within rectangular blocks of size height
    /// × width, which are stacked on top of each other, and there are empty stripes of size yOffset × width left
    /// between each two consecutive blocks.
    /// Asana lets you use a simple click and drag motion to select multiple tasks - i.e., you can click on the first
    /// task in your desired selection, then drag the mouse to the last task in your desired selection. The selected
    /// tasks can be visualized as follows: If you join the initial and the final positions of the mouse by a line,
    /// every task block that has at least one point in common with this line is considered to be "selected".
    /// To test your skills, Asana engineers want you to implement a function that determines which tasks are selected
    /// based on the initial and final positions of the mouse.
    /// </assignment>
    /// <param name="dimensions"></param>
    /// <param name="tasks"></param>
    /// <param name="mouseCoordinates"></param>
    /// <returns></returns>
    public static string[] MultiSelection(int[] dimensions, string[] tasks, int[][] mouseCoordinates)
    {
      throw new NotImplementedException();
    }


    /// <assignment>
    /// As a new engineer at Asana, you're working on a feature that helps users estimate how long it will take them
    /// to complete their workload. All a user has to do is specify the number of hours they work every day, provide
    /// the time allocated for each task, and the feature automatically calculates the number of days it will take for
    /// the user to finish all of their tasks. Since you think it's a bad habit to leave a given task unfinished at
    /// the  end of a day, tasks should be distributed so that each one will be completed during the working hours of
    /// a single day.
    /// Given the time allocated to a user's tasks and their daily workingHours, return the minimum number of days
    /// necessary for them to complete the given tasks. If there's no way to tackle all of them, return -1 instead.
    /// </assignment>
    /// <param name="workingHours"></param>
    /// <param name="tasks"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int TasksScheduling(int workingHours, int[] tasks)
    {
      throw new NotImplementedException();
    }
  }
}