Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = (int)Math.Log10(num) + 1;
int ZeroCount = 0;
int divisor  = 1;
int result = num % 10;
while (ZeroCount < numbers)
{
    divisor = divisor * 10;
    ZeroCount++;
    result = result + (num / divisor % 10);
}
int num2 = num / divisor;
Console.WriteLine("Результат сложения = {0}",result);