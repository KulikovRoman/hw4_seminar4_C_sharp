// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах).  Реализовать через функции. (* Доп сложность, 
// “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8


void FillArray(int[] array)     // метод заполнения массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = rnd.Next();  // условие для основного решения
        array[i] = rnd.Next(0, 100); // доп. условие: ввод минимального (0) и максимального (99) значений
    }
}

void PrintArray(int [] array)   // метод вывода массива
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", " + array[i]);
    }
}

int InputSizeArray(string msg)  // метод ввода числа
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(System.Console.ReadLine());
}

//int[] array = new int[8]; // для автоматического определения размера массива
// FillArray(array);
// PrintArray(array);
int sizeArray = InputSizeArray("Введите размер массива");// доп. условие о вводе размера массива
int[] array = new int[sizeArray];
FillArray(array);
PrintArray(array);