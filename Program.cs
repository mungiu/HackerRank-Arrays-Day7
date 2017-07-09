using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        //array size
        char N = Convert.ToChar(Console.ReadLine());
        string A = Console.ReadLine();
        string[] aTemp = A.Split(' ', N);
        Array.Reverse(aTemp);
        foreach (string substring in aTemp)
        {
            Console.Write($"{substring.ToString()} ");
        }
    }
}