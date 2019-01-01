using System;
using System.Collections.Generic;
using System.Collections;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    public  int MaxLength = 0;
    public  int [] data = new int[]{1200,11,56,21,3};
    public List<List<int>> storage = new List<List<int>>();
    static void Main(string[] args)
    {
        int num = 55;
        
        //bool a = divisible(num);
        
        string s = "12 6ajsal", result;
        Console.WriteLine(s);
        
        char[] arr = s.ToCharArray();
        
        List<char> ls = new List<char>();
        
        for(int i=arr.Length-1; i>=0 ; i--)
        {
            //Console.Write(arr[i]);
            ls.Add(arr[i]);
        }
        
        result = String.Join("", ls);
        //Console.WriteLine(result);
        
        
    }
    
    
}
