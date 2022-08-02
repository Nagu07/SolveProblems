// Compressed string. display char and count

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string input = "accccdeeety";
    CompressString(input);
  }

  private static void CompressString(string input)
  {
    Dictionary<char, int> charDictionary = new Dictionary<char,int>();
    int charCount = 0;
    foreach(var i in input)
    {
      charDictionary.TryGetValue(i,out charCount);
      if(charCount > 0)
      {
        charCount++;
        charDictionary[i] = charCount;
      }
      else {
        charDictionary.Add(i, 1);
      }
    }

    foreach(var t in charDictionary)
    {
      Console.Write(t.Key + "" + t.Value);
    }
  }
}
