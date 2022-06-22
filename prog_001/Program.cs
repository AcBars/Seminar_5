/*
Задача 32:** Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

using static System.Console;
Clear();

int [] array = RandomArray(5,5,-5);
WriteLine($"[{String.Join(", ", array)}]");
GetRevers (array);
WriteLine($"[{String.Join(", ", array)}]");


int [] RandomArray(int size, int maxValue, int minValue)
{
    int [] arr = new int [size];
    for(int i=0; i<size; i++)
    {
        arr [i]=new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

void GetRevers (int [] array)
{
   
    
    for(int i=0; i<array.Length; i++)
    {
        array [i]=array[i]*-1;
    }
    
}