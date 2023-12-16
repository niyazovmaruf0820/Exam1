int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int b = arr[0];
int c = arr[0];
for (int i = 0; i < a; i++)
{
   if (b > arr[i])
   b = i; 
   if (c < arr[i])
   c = i; 
}
for (int i = 0; i < a; i++)
{
    if (i >= b && i <= c && c > b) 
    Console.Write(arr[i] + " ");
    if (i <= b && i >= c && c < b) 
    Console.Write(arr[i] + " ");
}

