// Программа которая принимает число N и показывает все четные числа от числа 1 до числа N
Console.Write("Введите число/ ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(count < num)
{
    count++;
    if(count%2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
}