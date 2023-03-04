// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string prompt)
{
    System.Console.Write($"{prompt} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int MathPow(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

int userNumberA = InputInt("Введите число A ");
int userNumberB = InputInt("Введите число B ");
//int result = 1;
int resultNumber = MathPow(userNumberA, userNumberB);
System.Console.WriteLine($"Число {userNumberA} в степени {userNumberB} = {resultNumber}");

// int userNumberA = InputInt("Введите число A ");
// int userNumberB = InputInt("Введите число B ");
// int result = 1;
// for (int i = 0; i < userNumberB; i++)
// {
//     result = result * userNumberA;
// }
//Console.WriteLine(result);