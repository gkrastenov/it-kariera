# it-kariera

# Определете сложността

## Колко е Time and Space Complexity на:

Example 1: <br/>
```
int param = 5;
```

Example 2: <br/>
```
int n = Console.ReadLine();
Console.WriteLine(n);
``` 

Example 3: <br/>
```
int n = Console.ReadLine();
Console.WriteLine(n * n);
``` 

Example 5: <br/>
```
List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
Console.WriteLine(string.Join(' ', list));
``` 

Example 6: <br/>
```
var something = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.WriteLine(string.Join(' ', something));
``` 

Example 7: <br/>
```
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	Console.WriteLine(i);
}
``` 

Example 9: <br/>
```
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
 for (int j = 0; j < n; j++)
	{
		Console.WriteLine(i + j);
    }
}
``` 

Example 10: <br/>
```
var list = new List<int>();
for (int i = 0; i < n; i++)
{
 for (int j = 0; j < n; j++)
	{
		list.Add(i + j);
    }
}
``` 

Example 11: <br/>
```
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
        {
            matrix[i,j] = int.Parse(Console.ReadLine());
        }
     }
}
``` 

Example 12: <br/>
```
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); // въвеждам 1 2 3 4 5 6 7 8
            int element = 5;
            Console.WriteLine(IsFounded(list, 5));
            
        }
        public static bool IsFounded(List<int> list, int key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == key)
                    return true;
            }
            return false;
        }
``` 