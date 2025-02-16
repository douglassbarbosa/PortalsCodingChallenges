using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using PortalsCodingChallenges.Beecrowd;

namespace PortalsCodingChallenges.Test.Beecrowd
{
  [TestClass]
  public class Problem1000Test
  {
    [TestMethod]
    public void Test_HelloWorld_Output()
    {
      lock (this)
      {
        // get Console.Out reference
        using var output = new StringWriter();
      Console.SetOut(output);

      // run the problem
      var problem = new Problem1000();
      problem.Run();

        // assert the output
        Assert.AreEqual($"Hello World!{Environment.NewLine}", output.ToString());
      }
    }
  }
}
