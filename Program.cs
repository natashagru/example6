// программа, которая принимает на вход принимает число и выдает, является ли число чётным

Console.Clear();
Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine()!);

if ((a % 2) > 0)
{
    Console.WriteLine("нет, число не чётное");
}
else 
{
    Console.WriteLine("да, число чётное");
}