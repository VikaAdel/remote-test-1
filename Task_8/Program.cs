/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int honest = N % 2;


if (honest == 0)
{
    Console.Write(N +", ");

}

else 
{
    N -= 1;
    Console.Write(N +", ");
}

while (N > 2)
{
    N -= 2;
    Console.Write(N + ", ");
}



