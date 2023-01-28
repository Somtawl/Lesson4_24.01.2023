Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num1;

int GetSum(int num1, int num2)
{
    for (int i = 1;i < num2 ;i++)
    {
        result = result * num1;
        Console.WriteLine("result = {0} i = {1}",result,i);
    }
    return result;
}

Console.WriteLine("Итого = {0}",GetSum(result,num2));