void  Fibonacci(int a)
{
    for (int i = 0; i < a; i++)
    {
         i += i + 1;
    }
    for (int i = 0; i < a; i++)
    {
        Console.Write(i + "");
    }
}
int a = Convert.ToInt32(Console.ReadLine());
Fibonacci(a);
