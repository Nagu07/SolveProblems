// Urilify , input - Mr John Smith    ,13. output - Mr%20John%20Smith

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    string input = "Mr John Smith    ";
    int len = 13;
    Console.WriteLine(Urilify(input, len));
  }

  private static string UrilifyUsingStringBuilder(string input, int length)
  {
    StringBuilder s1 = new StringBuilder();
    foreach(var c in input.Substring(0, length))
    {
      if(c == ' ')
      {
        s1.Append("%20");
      }
      else {
        s1.Append(c);
      }
    }
    return s1.ToString();
  }

  private static string Urilify(string input, int length)
  {
    int space = 0, trueLength = 0;

    // Count number of spaces
    for(int i = 0; i < length; i++)
    {
      if(input[i] == ' ')
      {
        space++;
      }
    }

    if(space > 0)
    {
      trueLength = length + space * 2;
      Console.WriteLine(trueLength);
      char[] arr = new char[trueLength];

      for(int i=length - 1; i >= 0; i--)
      {
        if(input[i] == ' ')
        {
          arr[trueLength-1] = '0';
          arr[trueLength-2] = '2';
          arr[trueLength-3] = '%';
          trueLength = trueLength - 3;
        }
        else{
          arr[trueLength - 1] = input[i];
          trueLength--;
        }
      }

      return new String(arr);
    }

    return string.Empty;
  }
}
