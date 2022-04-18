int Parse(string message)
{
    Console.WriteLine(message);
    string strNum = Console.ReadLine();
    int Num = int.Parse(strNum);
    return Num;
}

void Even (int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        return;
    }
    if (arg1 % 2 == 0)
    {
        Console.Write(arg1 + " ");
        Even(arg1 + 2, arg2);
    }
    else
    {
        Even(arg1 + 1, arg2);
    }
}

int M = Parse("Введите первое число: ");
int N = Parse("Введите второе число: ");
Even(M,N);