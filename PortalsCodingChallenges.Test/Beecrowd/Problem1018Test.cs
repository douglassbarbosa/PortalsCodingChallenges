using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using PortalsCodingChallenges.Beecrowd;

namespace PortalsCodingChallenges.Test.Beecrowd
{
  [TestClass]
  public class Problem1018Test 
  {
    [TestMethod]
    public void TestProblem1018576() {
      lock (this)
      {
        using var output = new StringWriter();
        Console.SetOut(output);

        Problem1018.Run(576);
        Assert.AreEqual($"576{Environment.NewLine}5 nota (s) de R$ 100,00{Environment.NewLine}1 nota (s) de R$ 50,00{Environment.NewLine}1 nota (s) de R$ 20,00{Environment.NewLine}0 nota (s) de R$ 10,00{Environment.NewLine}1 nota (s) de R$ 5,00{Environment.NewLine}0 nota (s) de R$ 2,00{Environment.NewLine}1 nota (s) de R$ 1,00{Environment.NewLine}", output.ToString());
      }
    }
    public void Test_problem1018_11257() {
      lock (this)
      {
        using var output = new StringWriter();
        Console.SetOut(output);

        Problem1018.Run(11257);
        Assert.AreEqual($"11257{Environment.NewLine}112 nota (s) de R$ 100,00{Environment.NewLine}1 nota (s) de R$ 50,00{Environment.NewLine}1 nota (s) de R$ 20,00{Environment.NewLine}0 nota (s) de R$ 10,00{Environment.NewLine}1 nota (s) de R$ 5,00{Environment.NewLine}1 nota (s) de R$ 2,00{Environment.NewLine}0 nota (s) de R$ 1,00{Environment.NewLine}", output.ToString());
      }
    }
    public void Test_problem1018_503() {
      lock (this)
      {
        using var output = new StringWriter();
        Console.SetOut(output);

        Problem1018.Run(503);
        Assert.AreEqual($"503{Environment.NewLine}5 nota (s) de R$ 100,00{Environment.NewLine}0 nota (s) de R$ 50,00{Environment.NewLine}0 nota (s) de R$ 20,00{Environment.NewLine}0 nota (s) de R$ 10,00{Environment.NewLine}0 nota (s) de R$ 5,00{Environment.NewLine}1 nota (s) de R$ 2,00{Environment.NewLine}1 nota (s) de R$ 1,00{Environment.NewLine}", output.ToString());
      }
    }
  }
}