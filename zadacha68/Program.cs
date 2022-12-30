int Accerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Accerman(n - 1, 1);
    else
      return Accerman(n - 1, Accerman(n, m - 1));
}
Console.Clear();
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(Accerman( a, b));