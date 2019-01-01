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
        
        bool a = divisible(num);
        
        Console.WriteLine(a);
    }
    
    public static bool divisible(int num)
    {
        List<int> ls = new List<int>();
        bool flag = true;
        int temp = num;
        while(num>0)
        {
            ls.Add(num%10);
            num = num/10;
        }
        
        
        foreach(var i in ls)
        {
            //Console.WriteLine(i);
            if(i!=0)
            {
               if((temp%i) !=0)
                flag=false;
            }
            
            else
            {
              flag=false;
            }
        } //Console.WriteLine(i);
        
        return flag;

    
    }
}
