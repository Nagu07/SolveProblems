// Question - Given two strings write a alogorithm to determine if one is permutation of other

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string input1= "tae";
    string input2 = "ate"; // Input string, Manipulate input here to check algorithm
    Console.WriteLine("Permutation string result(boolean) - " + IsPermutationStrings(input1, input2));
  }

  private static bool IsPermutationStrings(string input1, string input2)
  {
    if(input1.Length != input2.Length)
    {
      return false;
    }

    // Order by strings and compare the position
    input1 = String.Concat(input1.OrderBy(c => c));
    input2 = String.Concat(input2.OrderBy(c => c));

    for(int i = 0; i < input1.Length; i++)
    {
      if(input1[i] != input2[i])
      {
        return false;
      }
    }
    return true;
  }
}
