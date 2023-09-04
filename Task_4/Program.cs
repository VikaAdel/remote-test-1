/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/



 int max = 0;

Console.Write("Введите первое число: "); // ввели 1 данные
int firstNumber = Convert.ToInt32(Console.ReadLine());
/* присвоили переменную и так 3 раза, потому что у нас 3 числа и преобразовали строковое представление числа с указанным основанием системы счисления в эквивалентное 
ему 32-битовое целое число со знаком, далее происходит чтение строки с переходом на новую строку
*/



Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > max) /* задали условие через if, и сравниваем сначала первое  число, больше ли оно max*/
{
    max = firstNumber;

}

if (secondNumber > max)
{
    max = secondNumber;

}

if (threeNumber > max)
{
    max = threeNumber;

}

Console.WriteLine("max = " + max);  /* вывели данные*/
