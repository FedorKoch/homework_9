int Summa( int a, int b, ref int sum)
{
    if(a <= b) {
    sum = sum + a;
 return Summa( a + 1, b , ref sum);
    }
    return sum;
}

Console.Clear();
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма чисел между введенными равна: ");
int sum = 0;
Console.WriteLine(Summa( a, b, ref sum));


