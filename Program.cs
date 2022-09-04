// Задача 2 - напишите программу которая на вход принимает 2 числа и выдает какое большее а какое меньшее
/* Console.Write("введите первое число");

int numbermax  = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");

int numbermin  = Convert.ToInt32(Console.ReadLine());


if(numbermin< numbermax)
{
    Console.Write ("Максимальное число" + numbermax + " Минимальное число" + numbermin);
}
else
{
   Console.Write ("Минимальное число" + numbermax + " Максимальное число" + numbermin); 
}*/

// Задача 4 - напишите программу которая на вход принимает 3 числа и выдает максимальное из этих чисел
/*
Console.Write("введите первое число");

int number1  = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число");

int number2  = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число");

int number3  = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number1>max) max = number1;
if(number2>max) max = number2;
if(number3>max) max = number3;

   Console.WriteLine ("Максимальное число" + max); 
*/
// Задача 6 - напишите программу которая на вход принимает число и выдает- является ли это число четным
/*
Console.Write("введите число");

int numberA  = Convert.ToInt32(Console.ReadLine());

   if (numberA % 2 == 0)
{
   Console.WriteLine ("да");
}  
else
{
   Console.Write ("нет");
} */
// Задача 8 - напишите программу , которая на вход  принимает число N , а на выходе показывает все числа от 1 до N
/*
Console.Write("введите число N ");
int number1 = Convert.ToInt32(Console.ReadLine());

int current = 1 ;
while (current<=number1)
{
   if(current % 2 == 0)

    Console.Write(current + " ");
    current = current + 1;
} */