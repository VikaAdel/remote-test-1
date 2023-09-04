
/*Напишите программу, которая выводит случайное число из отрезка(10,99) и показывает наибольшую цифру числа
78 -> 8
12-> 2
85-> 8*/

int GetTwoDigitNumber(int minValue = 10, int maxValue = 99) //Переменная
{
    return new Random().Next(minValue, maxValue + 1); //Условие
}


int GetMaxDigit(int TwoDigitNumber)
{
    int dig_1 = TwoDigitNumber / 10; // 8
    int dig_2 = TwoDigitNumber % 10;
   

   /* if (dig_1 > dig_2)
  
        return dig_1;
    else
      
        return dig_2; */

    return dig_1 > dig_2 ? dig_1 : dig_2; 
   

}
// int number = GetTwoDigitNumber();



int number = GetTwoDigitNumber(); // Вывод

Console.WriteLine(number);
Console.WriteLine(GetMaxDigit(number));

