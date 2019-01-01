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
        Solution s = new Solution();
 
        for(int f=0; f<10; f++)
        {
          s.storage.Add(new List<int>());
        }
        
        Console.WriteLine("Before Sorting:");
        
        //Console.WriteLine(data[0].ToString().Length);
                foreach(var y in s.data)
            Console.WriteLine(y);
        
        
        for(int i=0; i<s.data.Length; i++)
        {
          if(s.data[i].ToString().Length>s.MaxLength)
          {
            s.MaxLength = s.data[i].ToString().Length;
          }
        }
        
        //Console.WriteLine(s.MaxLength);
        Console.WriteLine("After Sorting:");
        s.data = s.RadixSort(s.data);
        
        foreach(var y in s.data)
            Console.WriteLine(y);

        //int howzat = Convert.ToInt32(Math.Floor((6571900 % Math.Pow(10, 3))/Math.Pow(10, 2)));
        



        
    }
    
    public  int[] RadixSort(int[] data)
    {
        for(int k=0; k<MaxLength; k++)
        {
            for(int j=0; j<data.Length; j++)
            {
              int digit = (int)((data[j] % Math.Pow(10, k + 1)) / Math.Pow(10, k));
                
                storage[digit].Add(data[j]);
                
   
                    
            }    
 
              int index1 = 0;                     
              for(int p=0; p<storage.Count; p++)
              {
                List<int> sell = storage[p];//new List<int>();
                 
                for(int q = 0; q<sell.Count; q++)
                {
                    //Console.WriteLine(sell[q]);
                   data[index1++] = sell[q];
                    
                }
                
                       
              }
            clearstorage(); 
            
        }
        
        return data;

              
    }
                        
    private  void clearstorage()
    {
       for (int k = 0; k < storage.Count; k++)
            {
                storage[k].Clear();
            }
    }
    

    
}
