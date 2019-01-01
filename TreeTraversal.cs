class Solution
{
    static void Main(string[] args)
    {
       BinaryTree n = new BinaryTree();
       
       n.root = new Node(5);
        n.root.left = new Node(2);
         n.root.right = new Node(1);
        
       //Console.WriteLine(n.root.key); 
       n.printpreorder(n.root);
       
        
    }
    
    

    
}

internal class BinaryTree
{
  public Node root;
  
  public BinaryTree()
  {
     root = null;
  }
  
  public void printpreorder(Node n)
  {
       //Console.WriteLine(n.key);
 
    if(n==null)
    {
      return;
    }
    
     Console.WriteLine(n.key);
    
    if(n.left!=null)  
    printpreorder(n.left);
        if(n.right!=null)
    printpreorder(n.right);
    
  
  }

public int inordertraversal (Node root, List<int>)
{
    
    if(root==null)
    { 
      return;
    }
    
    if(root.left!=null)
    {
       inordertraversal(root.left);
    }
    
    ls.Add(root.value);
    
    if(root.left!=null)
    {
       inordertraversal(root.right);
    }

}
  
}
internal class Node
{
  public Node left, right;
  public int key;
  
  public Node(int item)
  {
      key  = item;
      left=right=null;
  }
    
}
