// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if (num > num2) Console.WriteLine($"{num}");
else if (num2 > num) Console.WriteLine($"{num2}");
else if (num == num2) Console.WriteLine("Числа равны");