Console.WriteLine("Укажите количество элементов в массиве ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите значение максимального элемента в массиве");
int ArrayMax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите значение минимального элемента в массиве");
int ArrayMin = Convert.ToInt32(Console.ReadLine());
var Rand = new Random();
if (ArrayMin < ArrayMax)
{
   int[] UserArray = new int[ArraySize];
    for (int i = 0; i < ArraySize;i++)
    {
        UserArray[i] = Rand.Next(ArrayMin,ArrayMax + 1);
    }
    ToConsole(UserArray);
}
else
{
    Console.WriteLine("Неверные значения для максимального и минимального объекта в массиве.");
}
void ToConsole(int[] SomeArray)
{
    Console.Write("Массив ");
    for (int i = 0; i < SomeArray.Length;i++)
    {
        Console.Write("{0} ",SomeArray[i]);
    }
}