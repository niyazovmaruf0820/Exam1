int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
Pribavit(a);
void Pribavit(int a)
{
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int f = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
   arr[i] += f;
} 
for (int i = 0; i < a; i++)
{
    System.Console.Write(arr[i] + " ");
}
}
