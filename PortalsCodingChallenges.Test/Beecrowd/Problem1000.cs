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
      // Captura a saída do console
      using var output = new StringWriter();
      Console.SetOut(output);

      // Executa o problema
      var problem = new Problem1000();
      problem.Run();

      // Verifica a saída esperada
      Assert.AreEqual("Hello World!\n", output.ToString());
    }
  }
}
