/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */



Console.Write("Является ли число четным: ");
int numberA = Convert.ToInt32(Console.ReadLine());


int numberC = numberA % 2;

if (numberC == 0)

{
    Console.WriteLine("Да");
}

else
{

    Console.WriteLine("Нет");

}



