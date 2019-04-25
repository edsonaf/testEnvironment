using System.IO;
using System.Reflection;
using NUnit.Framework;
using TestEnvironment.CompanyChallenges.VerkadaChallenges;

namespace TestEnvironmentUnitTests.CompanyChallenges.VerkadaChallengesTests
{
  [TestFixture]
  [Timeout(3000)]
  public class VerkadaAnalyzeIpAddressesTests
  {
    [TearDown]
    public void DeleteTestFolder()
    {
      string baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      string rootDir = baseDir + "/root";
      foreach (var directory in Directory.GetDirectories(rootDir))
      {
        Directory.Delete(directory, true);
      }
      Directory.Delete(rootDir, true);
    }

    [Test]
    public void AnalyzeIpAddressesTest01()
    {
      // Arrange
      string baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      string rootDir = baseDir + "/root";
      string dir1 = rootDir + "/dir1";
      string dir2 = rootDir + "/dir2";

      Directory.CreateDirectory(rootDir);
      Directory.CreateDirectory(dir1);
      Directory.CreateDirectory(dir2);

      string file1Path = dir1 + "/file1.txt";
      string file2Path = dir1 + "/file2.txt";
      string file3Path = dir2 + "/file3.txt";
      string file4Path = dir2 + "/file4.txt";
      string rootFile = rootDir + "/f.inp";

      File.Create(file1Path).Dispose();
      File.Create(file2Path).Dispose();
      File.Create(file3Path).Dispose();
      File.Create(file4Path).Dispose();
      File.Create(rootFile).Dispose();

      using (TextWriter tw = new StreamWriter(file1Path))
      {
        tw.WriteLine("hello world 127.0.0.1\nthis is some example 128.99.107.55 \nfile " +
                     "with some correct and incorrect 128.128.4.11 ip 0.11.1115.78 addressesaddresses");
      }

      using (TextWriter tw = new StreamWriter(file2Path))
      {
        tw.WriteLine("hello from 74.0.65.76 and 8.dd.99.88.907 good\nthis is some example 16.1215.76.35 \nfile " +
                     "with some correct and incorrect 15.128.4.65 ip addresses\n0.0.0.0");
      }

      using (TextWriter tw = new StreamWriter(file3Path))
      {
        tw.WriteLine("127.65.64.1 127.0.64.1 127.0.0.1\nexample 128.57.107.76 128.57.907.70 \nfile with some " +
                     "correct and incorrect 67.128.4.11 ip addresses 7.7.7.8");
      }

      using (TextWriter tw = new StreamWriter(file4Path))
      {
        tw.WriteLine("hello world 127.98.0.1\nthis is some example 128.96.107.55 \nfile with some correct and " +
                     "incorrect 128.68.4.11 ip addresses");
      }

      using (TextWriter tw = new StreamWriter(rootFile))
      {
        tw.WriteLine("hello world 127.0.49.1 \nthis is some example 128.99.58.55 8.88.888.88 " +
                     "77.255.255.254\n7.7.257.25 file with some correct and incorrect 26.56.4.23 ip addresses");
      }

      string[] expected =
      {
        "0.0.0.0",
        "127.0.0.1",
        "127.0.49.1",
        "127.0.64.1",
        "127.65.64.1",
        "127.98.0.1",
        "128.128.4.11",
        "128.57.107.76",
        "128.68.4.11",
        "128.96.107.55",
        "128.99.107.55",
        "128.99.58.55",
        "15.128.4.65",
        "26.56.4.23",
        "67.128.4.11",
        "7.7.7.8",
        "74.0.65.76",
        "77.255.255.254"
      };

      // Act
      string[] analyzeIpAddresses = VerkadaAnalyzeIpAddresses.AnalyzeIpAddresses(rootDir);

      // Assert
      Assert.AreEqual(expected, analyzeIpAddresses);
    }


    [Test]
    public void AnalyzeIpAddressesTest02()
    {
      string baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      string rootDir = baseDir + "/root";
      string dir1 = rootDir + "/dir1";
      string dir2 = rootDir + "/dir2";

      Directory.CreateDirectory(rootDir);
      Directory.CreateDirectory(dir1);
      Directory.CreateDirectory(dir2);

      string file1Path = dir1 + "/file1.txt";
      File.Create(file1Path).Dispose();
      using (TextWriter tw = new StreamWriter(file1Path))
      {
        tw.WriteLine("hello world 65.0.45.1 \nthis is some example 57.254.64.34\nfile with some correct and " +
                     "incorrect 54.76.4.56 ip addresses");
      }
      
      string file2Path = dir1 + "/file2.txt";
      File.Create(file2Path).Dispose();
      using (TextWriter tw = new StreamWriter(file2Path))
      {
        tw.WriteLine("    hello world 87.0.65.76 \nthis is some example 36.5.76.35 \nfile with some correct " +
                     "and incorrect 15.128.4.65 ip addresses");
      }
      
      
      string file4Path = dir2 + "/file4.txt";
      File.Create(file4Path).Dispose();
      using (TextWriter tw = new StreamWriter(file4Path))
      {
        tw.WriteLine("  file4.txt\n    hello world 127.98.0.1 \nthis is some example 128.96.107.55 \nfile with " +
                     "some correct and incorrect 128.68.4.11 ip addresses");
      }
      
      string file5Path = dir2 + "/file5.txt";
      File.Create(file5Path).Dispose();
      using (TextWriter tw = new StreamWriter(file5Path))
      {
        tw.WriteLine("  hello world 127.0.49.1 \nthis is some example 128.99.58.55 \nfile with some correct and " +
                     "incorrect 26.56.4.23 ip addresses");
      }

      string secondFile1Path = dir2 + "/file1.txt";
      File.Create(secondFile1Path).Dispose();
      using (TextWriter tw = new StreamWriter(secondFile1Path))
      {
        tw.WriteLine("hello world 54.0.0.1 \nthis is some example 76.99.46.55 \nfile with some correct and " +
                     "incorrect 78.45.4.87 ip addresses\n");
      }

      string thirdFile1Path = rootDir + "/file1.txt";
      File.Create(thirdFile1Path).Dispose();
      using (TextWriter tw = new StreamWriter(thirdFile1Path))
      {
        tw.WriteLine("hello world 65.0.45.1 \nthis is some example 57.254.64.34\nfile with some correct and " +
                     "incorrect 54.76.4.56 ip addresses");
      }

      string secondFile2Path = rootDir + "/file2.txt";
      File.Create(secondFile2Path).Dispose();
      using (TextWriter tw = new StreamWriter(secondFile2Path))
      {
        tw.WriteLine("hello world 0.0.0.0 \nthis is some example 57.2540.64.34\nfile with some correct and " +
                     "incorrect 54.76.400.56 ip addresses");
      }
      
      string[] expected =
      {
        "0.0.0.0",
        "127.0.49.1",
        "127.98.0.1",
        "128.68.4.11",
        "128.96.107.55",
        "128.99.58.55",
        "15.128.4.65",
        "26.56.4.23",
        "36.5.76.35",
        "54.0.0.1",
        "54.76.4.56",
        "57.254.64.34",
        "65.0.45.1",
        "76.99.46.55",
        "78.45.4.87",
        "87.0.65.76"
      };
      
      // Act
      string[] analyzeIpAddresses = VerkadaAnalyzeIpAddresses.AnalyzeIpAddresses(rootDir);

      // Assert
      Assert.AreEqual(expected, analyzeIpAddresses);
    }
  }
}