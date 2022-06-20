/*

*/

Write("Введите 2 элемента через пробел");
Scring[] array=ReadLine().Split(' ',stringSplitOptions.RemoveEmptyEntries);
int a1=int.Parse(array[0]);
int a2=int.Parse(array[1]);
WriteLne($"{aq1}->{a2}");










int [] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(',',stringSplitOptions.RemoveEmptyEntries);
     int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
    {
        result[i]=int.Parse(arS[i]);
    }
    return result;
}