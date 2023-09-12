// Программа которая выдает наибольшее и наименьшее из введенных чисел 
Console.Write("Введите число #1/ ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число #2/ ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write(num1);
    Console.Write(" Наибольшее число, ");
    Console.Write(num2);
    Console.WriteLine(" Наименьшее");
}

else
{
    Console.Write(num2);
    Console.Write(" Наибольшее число, ");
    Console.Write(num1);
    Console.WriteLine(" Наименьшее");
}