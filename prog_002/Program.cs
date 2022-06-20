/*
*Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да
*/

using static System.Console;
Clear();
WriteLine("Введите число");
int number=int.Parse(ReadLine());
int [] array=GetRandomArray(5,-5,5);
WriteLine($"{number}; массив [{String.Join("," array)});

//int[] array= [6, 7, 19, 345, 3];

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    
}

bool FindNumber(int[] array, int numbers)
{
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]==numbers)
        {

        }
    }
}
