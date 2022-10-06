//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт
//какое число большее, а какое меньшее
/*
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
    */

    // Задача 4
   // Напишите программу,
   //  которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
         if (b > max)
             {
                max = b;
             }
        if  (c > max)
             {
                  max=c;
             }
Console.Write("Максимальное число = "+max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
         
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
            Console.Write("Четное число");
    } 
    else Console.Write("Нечетное число");
*/
//Задача №8 
//Показать чётные числа от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i += 2)
    {
      Console.Write(i +" ");
    }
