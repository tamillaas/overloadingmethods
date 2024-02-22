#region task1
int numbers(int a,int b,int c)
{
    int sum = 0;
    if (a > 10 && a < 100)
    {
        sum += a;
    }
    if (b > 10 && b < 100)
    {
        sum += b;
    }
    else
    {
        sum += c;
    }
    return sum; 
}
Console.WriteLine(numbers(23, 9, 17));
#endregion
#region task3
int multi(int z)
{
    int a = default;
    int b = default;
    int c = default;
    int hasil = default;
    a = z % 10;
    b = z / 100;
    c = (z / 10) % 10;
    hasil = a * b * c;
    return hasil;
}
Console.WriteLine(multi(231));
#endregion
#region task4
int product(int a,int b,int c)
{
    int sum = 0;
    if(a>b || a > c)
    {
        sum += a;
    }
    if (b>c || b > a)
    {
        sum += b;
    }
    if (c>a || c > b)
    {
        sum += c;
    }
    else
    {
        Console.WriteLine(sum);
    }
    return sum;
}
Console.WriteLine(product(10,5,20));
#endregion


