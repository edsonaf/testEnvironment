#pragma warning disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestEnvironment.CompanyChallenges.VerkadaChallenges
{
  public static class VerkadaAnalyzeIpAddresses
  {
    /// <assignment>
    /// Your Verkada security camera is part of your home automation network. You're trying to debug an issue, so you
    /// need to consult your data logs. You're mainly interested in seeing which devices are communicating with each
    /// other, so you'd like to find all the IP addresses within the logs.
    /// </assignment>
    public static string[] AnalyzeIpAddresses(string root)
    {
      // get text from all files from all directories inside root
      string allString = DirSearch(root).Aggregate("", (current, file) => current + File.ReadAllText(file));

      // detect ip addresses using regex
      Regex ip = new Regex(@"\b(?:(?:[0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.){3}(?:[0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\b");
      MatchCollection result = ip.Matches(allString);

      // show all ip addresses once only
      IEnumerable<string> enumerable = result.OfType<Match>().Select(m => m.Groups[0].Value).Distinct();

      // order ascending
      IOrderedEnumerable<string> orderedEnumerable = enumerable.OrderBy(o => o);

      return orderedEnumerable.ToArray();
    }

    private static IEnumerable<string> DirSearch(string sDir)
    {
      List<string> files = new List<string>();
      try
      {
        files.AddRange(Directory.GetFiles(sDir));
        foreach (string directory in Directory.GetDirectories(sDir))
        {
          files.AddRange(DirSearch(directory));
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      return files;
    }
  }
}