// Question - Implement a alogorithm to determine if string has all unique chars. 
// What if you cannot use additional data structures ?

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string input = "HHel"; // Input string, Manipulate input here to check algorithm
    Console.WriteLine("Unique string result(boolean) - " + IsUniqueWithoutDataStructure(input));
  }

  private static bool IsUniqueWithDataStructure(string input)
  {
    // Using list to check if already exist
    List<char> charsInInput = new List<char>();
    foreach(char i in input)
    {
      if(charsInInput.Contains(i))
      {
        return false;
      }
      charsInInput.Add(i);
    }
    return true;
  }

  private static bool IsUniqueWithoutDataStructure(string input)
  {
    input = String.Concat(input.OrderBy(c => c));
    for(int i = 0; i < input.Length - 1; i++)
    {
      if(input[i] == input[i+1])
      {
        return false;
      }
    }
    return true;
  }
}
