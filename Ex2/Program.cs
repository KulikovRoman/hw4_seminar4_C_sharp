// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int value)    // метод, кот. сумму цифр в числе
{
    int result = 0;
    for (int i = 0; i < value; i++) // цикл выполняется пока число value (введенное число) не станет 0
    {
        result = result + value % 10;
        value = value / 10;
    }
    return result;
}

int userNumber = InputInt("Введите число"); //вызов метода InputInt и присвоение значения обработки в переменную int userNumber
System.Console.WriteLine($"Сумма цифр числа {userNumber} = {GetSum(userNumber)}");