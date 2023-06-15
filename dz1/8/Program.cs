// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (num >= counter) 
{
    if (counter % 2 == 0) 
    {
        Console.Write(counter + " ");
    }
    counter ++;
}
