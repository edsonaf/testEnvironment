using System;

namespace TestEnvironment.CompanyChallenges
{
  public static class DropboxChallenges
  {
    /// <assignment>
    /// To set user expectations during file uploads, Dropbox indicates how long a file will take to transfer with its
    /// upload time estimator.
    /// Your goal is to implement a particular type of a upload time estimator. Suppose that several clients are
    /// uploading files to Dropbox at the same given moment. The ith client uploads a file of sizes(i) megabytes. For a
    /// single file, upload speed is v megabytes per second, but if there are several files uploading at the same time
    /// then uploads occur simultaneously in parallel threads. For each thread the upload speed equals v / n, where n
    /// is the number of currently active threads.
    /// Given each file's size and its upload start time, determine the upload end times.
    /// </assignment>
    /// <param name="sizes"></param>
    /// <param name="uploadingStart"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static int[] LoadTimeEstimator(int[] sizes, int[] uploadingStart, int v)
    {
      // v is in mb/s
      int amount = sizes.Length;
      

      throw new NotImplementedException();
    }
  }
}