class Solution
{
    static void Main(string[] args)
    {
 
      int [] arr = new int[]{6,5,1,2,4,10,5};
        
        SortedDictionary<int, int>  dict = new SortedDictionary<int,int>();
        
        for(int i = 0 ; i<arr.Length; i++)
        {
         if(dict.ContainsKey(arr[i]))
         {
           dict[arr[i]] = dict[arr[i]] +1; 
             
         }
        
         else
         {
           dict.Add(arr[i], 1);           
         }
        }
        foreach(var i in dict.Keys)
        {
          Console.WriteLine("The Key is {0} and value is {1}", i,  dict[i]);
        }
        
        int lsb = 0;
        
        int digit = (int)((101 % Math.Pow(10, lsb + 1)) / Math.Pow(10, lsb));
        Console.WriteLine(digit);
        
        /*
         int val = 30;
         string binaryNumberString = Convert.ToString(val, 2);
        
        Console.WriteLine(binaryNumberString);
        

        
        int position = 0;
        
        int a1 = countDigitsformula(val);
      
        Console.WriteLine(a1);
    */
        //string result = Convert.ToString(a1, 2);
        
        //Console.WriteLine(result);
        
        //char[] b = result.ToCharArray();
        
        //foreach(var i in b)
          //  Console.Write(i);
        
        //Console.WrtieLine(Convert.ToInt32(a1, 2));
        
        
        
    }
    
        public static int flipBit(int number, int position)
    {   // Number         = 1011
        // (1<<position)  = 0001
        // EXOR           = 1010
        return number >>= 1;//number & ~(1 << position);;        
    }
    
    
public static int countDigitsformula(int num)
    {
        return (int)Math.Log(num,2)+1; 
        //return (int)(Math.Floor(Math.Log(num))) + 1;
        
    }
    

    
}
