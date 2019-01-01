class Solution
{
    static void Main(string[] args)
    {
       //Console.WriteLine("");
       LinkedList l = new LinkedList();
       l.AddatFirst(1);
       l.AddatFirst(2);
       l.AddatLast(5); 
        l.printnode();
        
    }
  
}

internal class Node
{
  public int value;
  public Node Next;  
    
}

internal class LinkedList
{
  public Node current;
  public Node last;

  public  LinkedList()
  {
    last = new Node();
      current = last;
    //value = value1;
    //current=last = null;  
  }
    
  public void AddatLast(int key)
  {
      Node n = new Node(); 
      n.value = key;
      last.Next = n;
      last = n;
      
  }
   
  public void AddatFirst(int key)
  {
      Node n = new Node();
      n.value = key;
      n.Next = current.Next;
      current.Next = n ;    
  
  }  
    
  public void printnode()
  {
   Console.Write("Current-->");
   Node p = current;
   while(p.Next!=null)
   {
       p = p.Next;
      Console.Write(p.value);
       Console.Write("->");
       
   }
   
   Console.Write("Null");   
      
  }
}
