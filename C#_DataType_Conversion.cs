//Count of Integers :

Math.Ceiling(Math.Log10(n));

-------------------------------------------------------------------

//Array to List :

   string[] array = new string[]
        {
            "one",
            "five"
        };
        List<string> list1 = new List<string>(array);

//List to Array :

 List<string> list = new List<string>();
        list.Add("one");
string[] array = list.ToArray();

-------------------------------------------------------------------

//String to char Array :

char[] chars = str.ToCharArray();


//Array to String :

String.Join(" ", myStringArray);

-------------------------------------------------------------------

//Int to Array :

var digits = i.ToString().Select(t=>int.Parse(t.ToString())).ToArray();

//Array to Int :

String a;
int output;
int[] array = {5, 6, 2, 4};
foreach(int test in array)
{
a+=test.toString();
}
output=int.parse(a);

-------------------------------------------------------------------

//string to Char :

string[] arrayStrings = { "One", "Two", "Three" };
var charArrayList = arrayStrings.Select(str => str.ToCharArray()).ToList();

//Char to String :

char[] c = new char[15];
        c[0] = 'O';
        c[1] = 'n';
string s = new string(c);

-------------------------------------------------------------------

//Integer Separation:

            int j = 20657;
            List<int> l = new List<int>();
            //Your code goes here
            for(int i=0; j!=0; i++)
            {
                l.Add(j%10);
                
              j = j/10;
                
            }
            l.ForEach(el => Console.WriteLine(el));
