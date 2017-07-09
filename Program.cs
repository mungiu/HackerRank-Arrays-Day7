using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Solution
{
    public static object RegEx { get; private set; }

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        string A = Console.ReadLine();

        string pattern = @"\ ";
        string[] aTemp = Regex.Split(A, pattern);
        Array.Reverse(aTemp);
        string aFinal = String.Join(" ", aTemp);
        
        Console.Write(aFinal);
    }
}
