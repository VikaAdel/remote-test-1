/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Является ли данный день недели выходным ");
Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int day = int.Parse(Console.ReadLine()!);



if (day >= 1 && day <= 5)

{
    Console.WriteLine("нет");
}


if (day >= 6 && day <= 7)

{
    Console.WriteLine("да");
}





