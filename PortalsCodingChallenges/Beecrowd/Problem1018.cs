using Microsoft.VisualBasic;
using PortalsCodingChallenges.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalsCodingChallenges.Beecrowd
{
  public static class Problem1018
  {
    public static void Run(int value)
    {
      int[] notes = [100, 50, 20, 10, 5, 2, 1];
      Console.WriteLine(value);
      foreach (int note in notes)
      {
        int count = value / note;
        Console.WriteLine($"{count} nota (s) de R$ {note},00");
        value %= note;
      }
    }
  }
}
