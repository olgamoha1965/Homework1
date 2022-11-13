// Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    int max = number1; 
    Console.WriteLine($"Максимальное число - {number1}, минимальное число - {number2}");
} 
else
{
    int max = number2; 
    Console.WriteLine($"Максимальное число - {number2}, минимальное число - {number1}");  
}
*/

//Задача 4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2 && number1 > number3)
{
   Console.WriteLine($"Максимальное число - {number1}.");
}
if(number2 > number1 && number2 > number3)
{
   Console.WriteLine($"Максимальное число - {number2}.");
}
if(number3 > number2 && number3 > number1)
{
   Console.WriteLine($"Максимальное число - {number3}.");
}
*/
//Задача 6/
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = number % 2;
if(current == 0)
{
    Console.WriteLine($"Число {number} является четным.");
}
else
{
    Console.WriteLine($"Число {number} является нечетным.");
}
*/
//Задача 8.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}
if(num <= 1)
{
    Console.WriteLine($"Введенное число {num} не имеет четных чисел.");
}
*/