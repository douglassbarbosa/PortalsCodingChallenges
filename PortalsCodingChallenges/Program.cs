using System;
using System.Reflection;


namespace PortalsCodingChallenges
{
  internal static class Program
  {
    private static void Main()
    {
      Menu();
      var menuChoice = Console.ReadLine();

      Console.WriteLine("You choice " + menuChoice + "!");
      Console.WriteLine("Please to inform what Problem do you wanna to run?");
      var problemChoise = Console.ReadLine();

      if (menuChoice is not null && problemChoise is not null)
      {
        RunProblem(GetPlatformChoice(menuChoice), problemChoise);
      }
    }
    private static String GetPlatformChoice(String option)
    {
      return option switch
      {
        "1" => "Beecrowd",
        "2" => "HackerRank",
        "3" => "OFF",
        _ => "OFF",
      };
    }

    private static void Menu()
    {
      Console.WriteLine("Hi Dev");
      Console.WriteLine("What do you to run - Choice a number?");
      Console.WriteLine("1 - Beecrowd");
      Console.WriteLine("2 - HackerRank");
      Console.WriteLine(" _______ ");
    }

    private static void RunProblem(string platform, string problem)
    {
      var assembly = Assembly.GetExecutingAssembly();
      var type = assembly.GetType("PortalsCodingChallenges." + platform + "." + problem);
      if (type == null)
      {
        Console.WriteLine("Problem type not found.");
        return;
      }
      var instance = Activator.CreateInstance(type);
      if (instance == null)
      {
        Console.WriteLine("Problem instance could not be created.");
        return;
      }
      MethodInfo? method = type.GetMethod("Run");
      if (method == null)
      {
        Console.WriteLine("Run method not found.");
        return;
      }
      method.Invoke(instance, null);
    }
  }
}