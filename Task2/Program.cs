int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

int Sum(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        return 0;
    }
    return arg1 + Sum(arg1 + 1, arg2);
}

int M = Parse("Введите первое число: ");
int N = Parse("Введите второе число: ");
int a = Sum(M,N);
Console.WriteLine(a);
