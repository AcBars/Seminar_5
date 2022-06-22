/*
*Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да
*/

using static System.Console;
Clear();
int [] array = RandomArray (5,-5,5);
WriteLine("Введите число");
int number=int.Parse(ReadLine());
//WriteLine($"[{String.Join(", ", array)}]");
FaindArray(array, number);






int [] RandomArray(int size,  int minValue, int maxValue)
{
    int [] arr = new int [size];
    for(int i=0; i<size; i++)
    {
        arr [i]=new Random().Next(minValue, maxValue+1);
    }
    return arr;
}
void FaindArray (int [] array, int number)
{
    int count =0;
    for(int i=0; i<array.Length; i++)
    {
        if (number==array[i])
        {
            count++;
            //
            //break;
        }
    }
      WriteLine(count==0?$"Числа {number} нет в массиве [{String.Join(", ", array)}]."
      : $"Число {number} есть в массиве [{String.Join(", ", array)}].");
}