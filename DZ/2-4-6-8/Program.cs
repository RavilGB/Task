//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт
//какое число большее, а какое меньшее
Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    {
        Console.WriteLine($"{a} больше {b}");
    }
else if (b > a)
    {
        Console.WriteLine($"{a} меньше {b}");
    }   
    else Console.WriteLine($"{a} равны {b}");
